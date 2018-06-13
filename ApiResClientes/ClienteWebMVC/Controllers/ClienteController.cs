using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ClienteWebMVC.Models;
using ClienteWebMVC.ViewModel;

namespace ClienteWebMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            RegistroPlacasClient RP = new RegistroPlacasClient();
            ViewBag.listRegistroPlacas = RP.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        public ActionResult Create(RegistroPlacasViewModel cvm)
        {
            RegistroPlacasClient RP = new RegistroPlacasClient();
            RP.Create(cvm.registroplacas);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            RegistroPlacasClient RP = new RegistroPlacasClient();
            RP.Delate(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            RegistroPlacasClient RP = new RegistroPlacasClient();

            RegistroPlacasViewModel RVM = new RegistroPlacasViewModel();
            RVM.registroplacas = RP.find(id);
            return View("Edit", RVM);
        }

        [HttpPost]
        public ActionResult Edit(RegistroPlacasViewModel RVM)
        {
            RegistroPlacasClient RP = new RegistroPlacasClient();
            RP.Edit(RVM.registroplacas);
            return RedirectToAction("Index");
        }






    }
}