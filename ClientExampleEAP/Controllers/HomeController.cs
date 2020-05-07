using ClientExampleEAP.ExampleEAPService;
using ClientExampleEAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientExampleEAP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var serviceClient = new ExampleEAPService.Service1Client();
                   
            return View(serviceClient.GetAllCustomer());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            var serviceClient = new ExampleEAPService.Service1Client();
            serviceClient.GetAccount(model.Code,model.Pass);
            return RedirectToAction("Index");
        }
        public ActionResult Transfer(string scode)
        {
            var serviceClient = new ExampleEAPService.Service1Client();
            var customer = serviceClient.GetById(scode);
            return View(customer);
        }

        public ActionResult GetTranfer(string scode ,string rcode, double money)
        {
            var serviceClient = new ExampleEAPService.Service1Client();
            serviceClient.TransferMoney(scode,rcode,money);
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}