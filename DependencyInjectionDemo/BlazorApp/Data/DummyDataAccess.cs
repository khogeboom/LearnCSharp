namespace BlazorApp.Data
{
    public class DummyDataAccess : IDataAccess
    {
        private int age;

        public DummyDataAccess()
        {
            Random rnd = new Random();
            age = rnd.Next(1, 10);
        }

        public int GetUserAge()
        {
            return age;
        }
    }
}
