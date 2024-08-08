namespace REST_API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
    }

    public enum Department
    {
        HR, IT, Finance, Marketing
    }
}
