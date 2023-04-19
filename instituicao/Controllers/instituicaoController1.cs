using instituicao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instituicao.Controllers
{
    public class instituicaoController1 : Controller
    {

        private static IList<Models.instituicao> instituicoes = new List<instituicao>()
            {
                new instituicao()
                {


                }
            }
        


        // GET: instituicaoController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: instituicaoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: instituicaoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: instituicaoController1/Create
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

        // GET: instituicaoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: instituicaoController1/Edit/5
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

        // GET: instituicaoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: instituicaoController1/Delete/5
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
