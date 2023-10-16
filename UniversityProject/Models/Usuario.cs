using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Models
{
    public class Usuario
    {   
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        [DataType(DataType.Password)]
        public string Pass { get; set; }

    }
}
