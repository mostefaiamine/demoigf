using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoIGF.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// mission service
        /// </summary>
        private readonly IMissionService _ser;

        public HomeController(IMissionService ser)
        {
            _ser = ser;
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calc()
        {
         
            return View();
        }

        [HttpPost]
        public IActionResult Calc(MissionInfo info)
        {
            
            if (ModelState.IsValid)
            {
                TempData["montant"] = _ser.Calculer(info.Grade, info.Jours).ToString();
                return View();
                
            }
            return View(info);
        }
    }
}
