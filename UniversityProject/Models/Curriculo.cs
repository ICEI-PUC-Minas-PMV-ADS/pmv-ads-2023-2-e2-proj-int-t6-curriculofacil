using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace UniversityProject.Models
{
    [Table("Curriculos")]
    public class Curriculo
    {
        [Key]
        public int CurriculoID { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatorio informar o Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Obrigatorio informar o Sobreome")]
        public string LastName { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Obrigatorio informar o Telefone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Obrigatorio informar o Endereço")]
        public string Address { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Obrigatorio informar o Cidade")]
        public string City { get; set; }

        [Display(Name = "Cep")]
        [Required(ErrorMessage = "Obrigatorio informar o Cep")]
        public string PostalCode { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Obrigatorio informar o Estado")]
        public string Estate { get; set; }

        [Display(Name = "Objetivo Profissional")]
        [Required(ErrorMessage = "Obrigatorio informar o Objetivo")]
        public string Objetive { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
