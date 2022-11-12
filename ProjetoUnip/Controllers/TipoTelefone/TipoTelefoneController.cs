using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoUnip.Controllers.TipoTelefone
{
    public class TipoTelefoneController : Controller
    {
        // GET: TipoTelefoneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoTelefoneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoTelefoneController/Create
        public ActionResult Create()
        {
            var viewModel = new Models.TipoTelefone();
            
            return View(viewModel);
        }

        // POST: TipoTelefoneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoTelefoneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoTelefoneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoTelefoneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoTelefoneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
