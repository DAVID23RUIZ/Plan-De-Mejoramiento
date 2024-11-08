using Swashbuckle.AspNetCore.Annotations;

namespace EmployeeApi.Models
{
    public class Employee
    {
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public DateTime DateOfEntry { get; set; } = DateTime.Now;
    }
}