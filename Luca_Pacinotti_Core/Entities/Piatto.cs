using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Pacinotti_Core.Entities
{
    public class Piatto
    {
        public int IdPiatto { get; set; }
        public string Nome { get; set; }
        public decimal Costo { get; set; }
        public int IdMenuFK { get; set; }
        public Menu Menu { get; set; }

        public global::Luca_Pacinotti_MVC.Models.PiattoViewModel ToPiattoViewModel()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Id: {IdPiatto}\t{Nome}\t{Costo}";
        }
    }
}
