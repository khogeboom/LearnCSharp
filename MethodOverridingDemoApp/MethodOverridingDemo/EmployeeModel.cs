namespace MethodOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        // keyword "virtual" allows for the method to be overriden
        public virtual decimal GetPaycheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
