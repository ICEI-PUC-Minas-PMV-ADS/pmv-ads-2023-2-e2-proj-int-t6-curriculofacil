using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Models
{
    public class Formacao
    {
        [Key]
        public int FormacaoID { get; set; }
        [Display(Name = "Instituição de ensino ")]
        public string InstDeEnsino { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Display(Name = "Diploma")]
        public string Diploma { get; set; }
        [Display(Name = "Campo de estudo")]
        public string CampoDeEstudo { get; set; }
        public string Situacao { get; set; }
        [Display(Name = "Data de inicio")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de termino")]
        public DateTime DataTermino { get; set; }

        [ForeignKey("CurriculoID")]
        public int CurriculoID { get; set; }

        public Curriculo? Curriculo { get; set; }
    }
}
