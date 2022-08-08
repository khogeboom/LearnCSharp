using DemoLibrary;

namespace AccessModifiersDemo
{
    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
            // even though I am not in same assembly I still have access because I am inheriting
            // "protected" bypasses "internal"
        }
    }
}
