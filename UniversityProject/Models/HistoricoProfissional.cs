using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Models
{
    public class HistoricoProfissional
    {

        [Key]
        public int HistoricoProfissinalID { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Obrigatorio informar o Cargo")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Empregador")]
        [Display(Name = "Empregador")]
        public string Empregador { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a Data de Inicio")]
        [Display(Name = "Data de inicio")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a Data de Termino")]
        [Display(Name = "Data de termino")]
        [DataType(DataType.Date)]
        public DateTime DataTermino { get; set; }

        [ForeignKey("CurriculoID")]
        public int CurriculoID { get; set; }

        public Curriculo Curriculo { get; set; }

    }
}

