namespace SoftmassAssignment.Models.Domain
{
    public class Employee
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }   
        public long salary { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Department { get; set; }

    }
}
