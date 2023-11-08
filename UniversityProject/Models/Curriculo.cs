using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace UniversityProject.Models
{
    public class Curriculo
    {
        [Key]
        public int CVID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public int ID { get; set; }
        public Usuario Usuario { get; set; }
    }
}
