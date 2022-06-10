using System.ComponentModel.DataAnnotations;

namespace Luca_Pacinotti_MVC.Models
{
    public class PiattoViewModel
    {
        [Required]
        public int IdPiatto { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Costo { get; set; }
        [Required]
        public int IdMenu { get; set; }

        public override string ToString()
        {
            return $"Id: {IdPiatto}\t{Nome}\t{Costo}\t{IdMenu}";
        }
    }
}
