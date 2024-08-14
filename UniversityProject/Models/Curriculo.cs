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
        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Obrigatório informar o Sobreome")]
        public string LastName { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Obrigatório informar o Telefone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Obrigatório informar o Endereço")]
        public string Address { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Obrigatório informar o Cidade")]
        public string City { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Obrigatório informar o CEP")]
        public string PostalCode { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Obrigatório informar o Estado")]
        public string Estate { get; set; }

        [Display(Name = "Objetivo Profissional")]
        [Required(ErrorMessage = "Obrigatório informar o Objetivo Profissional")]
        public string Objetive { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
