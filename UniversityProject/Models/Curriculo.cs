using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace UniversityProject.Models
{
    public class Curriculo
    {
        [Key]
        public int CVID { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Nome")]  
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Sobreome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Telefone")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Endereço")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Cidade")]
        public string City { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Cep")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Estado")]
        public string Estate { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Objetivo")]
        public string Objetive { get; set; }
   

        [ForeignKey("IdUsuario")]
        private int IdUsuario { get; set; }

        
    }
}
