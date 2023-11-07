using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Models
{
    public class Usuario
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Pass { get; set; }

    }
}
