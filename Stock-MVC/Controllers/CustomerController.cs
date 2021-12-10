﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stock_MVC.Models.Entity;

namespace Stock_MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        StockProjectMVCEntities db = new StockProjectMVCEntities();
        public ActionResult Index()
        {
            var deyerler = db.TBL_MUSTERILER.ToList();
            return View(deyerler);
        }

        [HttpGet]
        public  ActionResult YeniMusteri()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMusteri(TBL_MUSTERILER p1)
        {
            db.TBL_MUSTERILER.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult SIL(int id)
        {
            var musteri = db.TBL_MUSTERILER.Find(id);
            db.TBL_MUSTERILER.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}