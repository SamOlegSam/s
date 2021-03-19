using s.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace s.Controllers
{
    public class HomeController : Controller
    {
        public GENERALEntities db = new GENERALEntities();
        public PhoneEntities db1 = new PhoneEntities();

        public ActionResult BirthDay()
        {

            List<C_get_ok_days3> birthday = new List<C_get_ok_days3>();
            //birthday = db.C_get_ok_days3.OrderBy(f => f.datbegin.Month).ThenBy(g => g.datbegin.Day).ToList();
            birthday = db.C_get_ok_days3.OrderBy(h=>h.fio).ToList();
            ViewBag.vvv = birthday;
            return View(birthday);

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Phone()
        {
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
               
        public ActionResult Vac()
        {
            return View();
        }

        public ActionResult Corruption()
        {
            string[] files = Directory.GetFiles(@"\\s\c$\Inetpub\wwwroot\DOCUMENTS\CORRUPTION\", "*", SearchOption.AllDirectories);
            string[] files1 = Directory.GetDirectories(@"\\s\c$\Inetpub\wwwroot\DOCUMENTS\CORRUPTION\", "*", SearchOption.AllDirectories);
            
            var list1 = new List<string>(Directory.GetFiles(@"\\s\c$\Inetpub\wwwroot\DOCUMENTS\CORRUPTION\"));
            var list2 = new List<string>(Directory.GetDirectories(@"\\s\c$\Inetpub\wwwroot\DOCUMENTS\CORRUPTION\"));
            var list3 = list2.Concat(list1);
            ViewBag.fil = files;
            ViewBag.fil1 = files1;
            ViewBag.li = list3;
            return View(list3);
        }
        public ActionResult CorruptionPath(string str)
        {           
            var list1 = new List<string>(Directory.GetFiles(str));
            var list2 = new List<string>(Directory.GetDirectories(str));
            var list3 = list1.Concat(list2);
            
            ViewBag.li = list3;
            return View(list3);
        }

        public ActionResult GetLastName(string str)
        {
            List<C_get_ok_days3> phoneList = new List<C_get_ok_days3>();
            phoneList = db.C_get_ok_days3.Where(p => p.fio.Contains(str) || p.doljn.Contains(str)).ToList();
            ViewBag.phone = phoneList;
            return View(phoneList);
        }
        public ActionResult GetLastName1(string str)
        {
            List<Phone> phoneList = new List<Phone>();
            phoneList = db1.Phone.Where(p => p.FIO.Contains(str) || p.Doljnost.Contains(str)).ToList();
            ViewBag.phone = phoneList;
            return View(phoneList);
        }
    }
}