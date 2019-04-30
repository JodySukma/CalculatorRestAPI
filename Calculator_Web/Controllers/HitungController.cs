using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Web.Controllers
{
    public class HitungController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            HitungModel hm = new HitungModel();
            return View(hm);
        }

        [HttpPost]
        public ActionResult Index(HitungModel p, double nilai1, double nilai2)
        {
            if (ModelState.IsValid)
            {
                HitungServiceModel hvc = new HitungServiceModel();
            }
            return View(p);
        }

        [HttpPost]
        public ActionResult Create(HitungModel p, double nilai1, double nilai2)
        {
            if (ModelState.IsValid)
            {
                HitungServiceModel hvc = new HitungServiceModel();
                hvc.Penjumlahan(nilai1, nilai2);
                return RedirectToAction("Hitung");
            }
            return View(p);
        }
    }
}