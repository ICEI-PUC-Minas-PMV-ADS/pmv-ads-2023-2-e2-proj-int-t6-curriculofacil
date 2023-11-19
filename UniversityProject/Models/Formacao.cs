using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Models
{
    public class Formacao
    {
        [Key]
        public int FormacaoID { get; set; }
        [Display(Name = "Instituição de ensino ")]
        [Required(ErrorMessage = "Obrigatorio informar a Instituição de Ensino")]
        public string InstDeEnsino { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Display(Name = "Diploma")]
        [Required(ErrorMessage = "Obrigatorio informar o Diploma")]
        public string Diploma { get; set; }
        [Display(Name = "Campo de estudo")]
        [Required(ErrorMessage = "Obrigatorio informar o Campo de estudo")]
        public string CampoDeEstudo { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Situação")]
        public string Situacao { get; set; }
        [Display(Name = "Data de inicio")]
        [Required(ErrorMessage = "Obrigatorio informar a Data de Inicio")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de termino")]
        [Required(ErrorMessage = "Obrigatorio informar a Data de termino")]
        public DateTime DataTermino { get; set; }

        [ForeignKey("CurriculoID")]
        public int CurriculoID { get; set; }

        public Curriculo? Curriculo { get; set; }
    }
}
