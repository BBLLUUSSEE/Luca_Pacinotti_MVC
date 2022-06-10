using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Luca_Pacinotti_MVC.Models
{
    public class MenuViewModel
    {
        [DisplayName("Id menu")]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public int IdMenu { get; set; }
        [Required]
        public string Nome { get; set; }
        public ICollection<PiattoViewModel> Piatto { get; set; } = new List<PiattoViewModel>();


        public override string ToString()
        {
            return $"{IdMenu}\t{Nome}";
        }
    }
}
