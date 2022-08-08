using SupportLibrary.DataAccess;
using SupportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public class PersonSqlDataService : IPersonDataService
    {
        private readonly ISQLDataAccess _dataAccess;

        public PersonSqlDataService(ISQLDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task CreatePerson(IPersonModel person)
        {
            var p = new
            {
                person.FirstName,
                person.LastName,
                person.DateOfBirth
            };
            await _dataAccess.SaveData("dbo.spPeople_Create", p, "SQLDB");
        }

        public async Task<List<IPersonModel>> ReadPeople()
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeople_Read", new { }, "SQLDB");

            return people.ToList<IPersonModel>();
        }

        public async Task<IPersonModel> ReadPeople(int id)
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeople_ReadOne", new { Id = id }, "SQLDB");

            return people.FirstOrDefault();
        }

        public async Task UpdatePerson(IPersonModel person)
        {
            await _dataAccess.SaveData("dbo.spPeople_Update", person, "SQLDB");
        }

        public async Task DeletePerson(int id)
        {
            await _dataAccess.SaveData("dbo.spPeople_Delete", new { Id = id }, "SQLDB");
        }

        public async Task<List<IPersonModel>> SearchPeople(string searchTerm)
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeople_Search", new { SearchTerm = searchTerm }, "SQLDB");

            return people.ToList<IPersonModel>();
        }
    }
}
