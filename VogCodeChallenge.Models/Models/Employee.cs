using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using VogCodeChallenge.Entities.Enums;

namespace VogCodeChallenge.Entities.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public JobTitle JobTitle { get; set; }
        public string MailingAddress { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [JsonIgnore]
        public virtual Department Department { get; set; }
    }
}
