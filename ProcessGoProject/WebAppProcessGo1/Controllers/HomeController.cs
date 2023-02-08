using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Web;
using System.Web.Mvc;

namespace WebAppProcessGo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Status = ServiceStatus().ToString();
            return View();
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

        public ActionResult StartService()
        {
            return RedirectToAction("Index");
        }

        public ActionResult StopService()
        {
            return RedirectToAction("index");
        }

        private void Stop()
        {
            ServiceController sc = new ServiceController("ProcessGo1Service");
            if(sc.Status == ServiceControllerStatus.Running)
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(5000);
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
        }

        private void Start()
        {
            ServiceController sc = new ServiceController("ProcessGo1Service");
            if(sc.Status != ServiceControllerStatus.Running && sc.Status != ServiceControllerStatus.StartPending)
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(5000);
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
        }

        public ServiceControllerStatus ServiceStatus()
        {
            ServiceController sc = new ServiceController("ProcessGo1Service");
            return sc.Status;
        }

       
    }
}