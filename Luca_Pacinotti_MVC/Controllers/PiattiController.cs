using Luca_Pacinotti_Core.BusinessLayer;
using Luca_Pacinotti_MVC.Helpers;
using Luca_Pacinotti_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Luca_Pacinotti_MVC.Controllers
{
    public class PiattiController : Controller
    {

        private readonly IBusinessLayer BL;

        public PiattiController(IBusinessLayer bl)
        {
            BL = bl;
        }

        public IActionResult Index()
        {
            var studenti = BL.GetAllPiatto();
            List<PiattoViewModel> piattoViewModel = new List<PiattoViewModel>();
            foreach (var item in studenti)
            {
                piattoViewModel.Add(item.ToPiattoViewModel());
            }
            return View(piattoViewModel);
        }

        public IActionResult Details(int id)
        {
            var piatto = BL.GetAllPiatto().FirstOrDefault(s => s.IdPiatto == id);
            var piattoViewModel = piatto.ToPiattoViewModel();
            return View(piattoViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(PiattoViewModel piattoViewModel)
        {
            if (ModelState.IsValid)
            {
                var piatto = piattoViewModel.ToPiatto();
                var esito = BL.InserisciNuovoPiatto(piatto);
                if (esito.IsOk == true)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.MessaggioErrore = esito.Messaggio;
                    return View("ErroriDiBusiness");
                }
            }
            else
            {
                return View(piattoViewModel);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var piatto = BL.GetAllPiatto().FirstOrDefault(s => s.IdPiatto == id);
            var piattoViewModel = piatto.ToPiattoViewModel();
            return View(piattoViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var piatto = BL.GetAllPiatto().FirstOrDefault(s => s.IdPiatto == id);
            var piattoViewModel = piatto.ToPiattoViewModel();
            return View(piattoViewModel);
        }

        [HttpPost]
        public IActionResult Delete(PiattoViewModel piattoViewModel)
        {
            var piatto = piattoViewModel.ToPiatto();
            var esito = BL.EliminaPiatto(piatto.id);
            if (esito.IsOk == true)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.MessaggioErrore = esito.Messaggio;
                return View("ErroriDiBusiness");
            }
        }
    }
}
