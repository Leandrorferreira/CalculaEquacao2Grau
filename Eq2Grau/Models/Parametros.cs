using System.ComponentModel.DataAnnotations;

namespace Eq2Grau.Models
{
    public class Parametros
    {
        [Required(ErrorMessage ="Informe o parâmetro a")]
        public string stra { get; set; }
        [Required(ErrorMessage="Informe o parâmetro b")]
        public string strb { get; set; }
        [Required(ErrorMessage ="Informe o parâmetro c")]
        public string strc { get; set; }    
    }
}