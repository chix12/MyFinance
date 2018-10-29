using Domain;
using MyFinanceWeb.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinanceWeb.Controllers
{
    public class ProductController : Controller
    {
        ServiceProduct sp = new ServiceProduct();
        // GET: Product
        public ActionResult Index()
        {
            var Products = sp.GetMany();
            return View(Products);
        }
        [HttpPost]
        public ActionResult Index(String SearchCondition)
        {
            var Products = sp.GetMany(str => str.Name.Contains(SearchCondition));
            return View(Products);
        }
        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel pm)
        {
            try
            {
                Product p = new Product
                {
                    DateProd = pm.DateProd,
                    Category = pm.Category,
                    Description = pm.Description,
                    Name = pm.Name,
                    ImageName = pm.ImageName,
                    Price = pm.Price,
                    Quantity = pm.Quantity,
                    CategoryId = pm.CategoryId
                };
                // TODO: Add insert logic here
                sp.Add(p);
                sp.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
