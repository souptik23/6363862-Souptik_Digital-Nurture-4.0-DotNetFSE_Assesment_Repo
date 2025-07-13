using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1_6363862.Controllers
{
    public class ValuesController : Controller
    {
        // GET: ValuesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ValuesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValuesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValuesController/Create
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

        // GET: ValuesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValuesController/Edit/5
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

        // GET: ValuesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValuesController/Delete/5
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
