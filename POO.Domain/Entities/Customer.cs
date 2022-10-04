namespace POO.Domain.Entities
{
    public class Customer
    {
        public Customer(string name,  decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        public Customer(string name, decimal salary, DateTime? birthDate = null)
        {
            Name = name;
            BirthDate = birthDate;
            Salary = salary;
        }

        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
}