using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Models
{
    public class HistoricoProfissional
    {

        [Key]
        public int HistoricoProfissinalID { get; set; }

        [Display(Name = "Cargo")]
        public string Cargo { get; set; }
        [Display(Name = "Empregador")]
        public string Empregador { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Display(Name = "Data de inicio")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de termino")]
        public DateTime DataTermino { get; set; }

        [ForeignKey("CurriculoID")]
        public int CurriculoID { get; set; }

        public Curriculo? Curriculo { get; set; }

    }
}

