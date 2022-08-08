using DemoLibrary;

namespace AccessModifiersDemo
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUnsecureConnectionInfo();
            formerLastName = "test";
        }
    }
}
