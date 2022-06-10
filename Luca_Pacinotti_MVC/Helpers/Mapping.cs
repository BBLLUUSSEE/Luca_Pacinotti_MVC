using Luca_Pacinotti_Core.Entities;
using Luca_Pacinotti_MVC.Models;

namespace Luca_Pacinotti_MVC.Helpers
{
    public class Mapping
    {
        public static MenuViewModel ToMenuViewModel(this Menu menu)
        {
            List<PiattoViewModel> piattoViewModel = new List<PiattoViewModel>();
            foreach (var item in menu.Piatto)
            {
                piattoViewModel.Add(item.ToPiattoViewModel());
            }

            return new MenuViewModel
            {
                IdMenu = menu.IdMenu,
                Nome = menu.Nome,
            };
        }

        public static PiattoViewModel ToPiattoViewModel(this Piatto piatto)
        {
            return new PiattoViewModel()
            {
                IdPiatto = piatto.IdPiatto,
                Nome = piatto.Nome,
                Costo = piatto.Costo,
                IdMenu = piatto.IdMenuFK
            };
        }

        public static Menu ToMenu(this MenuViewModel menuViewModel)
        {
            List<Piatto> piatto = new List<Piatto>();
            foreach (var item in menuViewModel.Piatto)
            {
                piatto.Add(item.ToPiatto());
            }

            return new Menu
            {
                IdMenu = menuViewModel.IdMenu,
                Nome = menuViewModel.Nome
            };
        }

        public static Piatto ToPiatto(this PiattoViewModel piattoViewModel)
        {
            return new Piatto()
            {
                IdPiatto = piattoViewModel.IdPiatto,
                Nome = piattoViewModel.Nome,
                Costo = piattoViewModel.Costo,
                IdMenuFK = piattoViewModel.IdMenu
            };
        }
    }
}
