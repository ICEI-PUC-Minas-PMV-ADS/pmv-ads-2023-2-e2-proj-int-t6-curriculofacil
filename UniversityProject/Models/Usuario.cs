using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Models
{
    public class Usuario
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar nome.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a E-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar a senha.")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar perfil")]
        public Perfil Perfil { get; set; }

        public ICollection<Curriculo>? Curriculo { get; set; }
    }

    public enum Perfil
    {
        Usuario,
        Empresa
    }
}
