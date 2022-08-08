namespace MethodOverridingDemo
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        // replacing the method that was there by default with our own
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
