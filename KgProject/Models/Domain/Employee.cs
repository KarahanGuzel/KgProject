using System.ComponentModel.DataAnnotations.Schema;

namespace KgProject.Models.Domain
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Pw { get; set; }

        public long Salary { get; set; }

        public DateTime DateOfBirth { get; set;}

        public string Department { get; set; }
    }

}
