using Luca_Pacinotti_Core.Entities;
using Luca_Pacinotti_Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Pacinotti_Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryMenu menuRepo;
        private readonly IRepositoryPiatto piattiRepo;

        public MainBusinessLayer(IRepositoryMenu menu, IRepositoryPiatto piatti)
        {
            menuRepo = menu;
            piattiRepo = piatti;
        }









        #region Funzionalità Piatti
        public Esito EliminaPiatto(int idPiattoDaEliminare)
        {
            var piattoEsistente = piattiRepo.GetById(idPiattoDaEliminare);
            if (piattoEsistente == null)
            {
                return new Esito { Messaggio = "Nessun piatto corrispondente all'id inserito", IsOk = false };
            }
            piattiRepo.Delete(piattoEsistente);
            return new Esito { Messaggio = "Piatto eliminato correttamente", IsOk = true };
        }
        public List<Piatto> GetAllPiatto()
        {
            return piattiRepo.GetAll();
        }

        public Esito InserisciNuovoPiatto(Piatto nuovoPiatto)
        {
            Menu menuEsistente = menuRepo.GetByCode(nuovoPiatto.IdPiatto);
            if (menuEsistente == null)
            {
                return new Esito { Messaggio = "Codice piatto errato", IsOk = false };
            }
            piattiRepo.Add(nuovoPiatto);
            return new Esito { Messaggio = "piatto inserito correttamente", IsOk = true };
        }
        #endregion Funzionalità Piatti

        #region Funzionalità Menu
        public Esito AggiungiMenu(Menu nuovoMenu)
        {
            Menu menuRecuperato = menuRepo.GetByCode(nuovoMenu.IdMenu);
            if (menuRecuperato == null)
            {
                menuRepo.Add(nuovoMenu);
                return new Esito() { IsOk = true, Messaggio = "Menu aggiunto correttamente" };
            }
            return new Esito() { IsOk = false, Messaggio = "Impossibile aggiungere il menu perché esiste già un menu con quel codice" };
        }
        public Esito EliminaMenu(int id)
        {
            var menuRecuperato = menuRepo.GetByCode(id);
            if (menuRecuperato == null)
            {
                return new Esito() { IsOk = false, Messaggio = "Nessun menu corrispondente al codice inserito" };
            }
            menuRepo.Delete(menuRecuperato);
            return new Esito() { IsOk = true, Messaggio = "menu eliminato correttamente" };
        }

        public List<Menu> GetAllMenu()
        {
            return menuRepo.GetAll();
        }



        public Esito ModificaMenu(int id, string nuovoNome)
        {
            var menuRecuperato = menuRepo.GetByCode(id);
            if (menuRecuperato == null)
            {
                return new Esito() { IsOk = false, Messaggio = "Nessun menu corrispondente al codice inserito" };
            }
            menuRecuperato.Nome = nuovoNome;
            menuRepo.Update(menuRecuperato);
            return new Esito() { IsOk = true, Messaggio = "menu aggiornato correttamente" };
        }


        #endregion Funzionalità Menu
    }
}
