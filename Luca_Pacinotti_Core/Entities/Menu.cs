using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Pacinotti_Core.Entities
{
    public class Menu
    {
        public int IdMenu { get; set; } 
        public string Nome { get; set; }

        public ICollection<Piatto> Piatto { get; set; } = new List<Piatto>();
        public override string ToString()
        {
            return $"{IdMenu}\t{Nome}";
        }

    }
}
