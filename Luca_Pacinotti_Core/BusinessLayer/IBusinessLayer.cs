using Luca_Pacinotti_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Pacinotti_Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        List<Menu> GetAllMenu();
        Esito AggiungiMenu(Menu nuovoMenu);
        Esito ModificaMenu(int id, string nuovoNome);
        Esito EliminaMenu(int id);




        List<Piatto> GetAllPiatto();
        Esito InserisciNuovoPiatto(Piatto nuovoPiatto);
        Esito EliminaPiatto(int idPiattoDaEliminare);

        List<Piatto> GetPiattiByMenuCodice(int id);
    }
}
