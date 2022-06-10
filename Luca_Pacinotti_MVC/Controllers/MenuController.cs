using Luca_Pacinotti_Core.
using Luca_Pacinotti_Core.BusinessLayer;
using Luca_Pacinotti_Core.Entities;
using Luca_Pacinotti_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Luca_Pacinotti_MVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly IBusinessLayer BL;

        public MenuController(IBusinessLayer bl)
        {
            BL = bl;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Menu> menu = BL.GetAllMenu();
            List<MenuViewModel> menuViewModel = new List<MenuViewModel>();
            foreach (var item in menu)
            {
                menuViewModel.Add(item.ToMenuViewModel());
            }

            return View(menuViewModel);
        }




        [HttpGet("Menu/Details/{codice}")]
        public IActionResult Details(int id)
        {
            var menu = BL.GetAllMenu().FirstOrDefault(c => c.IdMenu == id);
            var menuViewModel = menu.ToMenuViewModel();
            return View(menuViewModel);
        }




        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }




        //[HttpPost]
        //public IActionResult Create(MenuViewModel menuViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Menu menu = menuViewModel.ToMenu();
        //        Esito esito = BL.AggiungiMenu(menu);
        //        if (esito.IsOk == true)
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        else
        //        {
        //            ViewBag.MessaggioErrore = esito.Messaggio;
        //            return View("ErroriDiBusiness");
        //        }
        //    }
        //    return View(menuViewModel );
        //}




        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var menu = BL.GetAllMenu().FirstOrDefault(c => c.IdMenu == id);
        //    var menuVM = menu.ToMenuViewModel();
        //    return View(menuVM);
        //}




        //[HttpPost]
        //public IActionResult Edit(MenuViewModel menuViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var menu = menuViewModel.ToMenu();
        //        Esito esito = BL.ModificaMenu(menu.IdMenu, menu.Nome);
        //        if (esito.IsOk == true)
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        else
        //        {
        //            ViewBag.MessaggioErrore = esito.Messaggio;
        //            return View("ErroriDiBusiness");
        //        }
        //    }
        //    return View(menuViewModel);
        //}



        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var menu = BL.GetAllMenu().FirstOrDefault(c => c.IdMenu == id);
        //    var menuVM = menu.ToMenuViewModel();
        //    return View(menuVM);
        //}





        //[HttpPost]
        //public IActionResult Delete(MenuViewModel menuViewModel)
        //{
        //    var menu = menuViewModel.ToMenu();
        //    Esito esito = BL.EliminaMenu(menu.IdMenu);
        //    if (esito.IsOk == true)
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    else
        //    {
        //        ViewBag.MessaggioErrore = esito.Messaggio;
        //        return View("ErroriDiBusiness");
        //    }

        //}
    }
}
