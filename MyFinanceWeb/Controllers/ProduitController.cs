
using Domaine;
using MyFinanceWeb.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinanceWeb.Controllers
{
    public class ProduitController : Controller
    {
     ServiceProduct sp = new ServiceProduct();
        ServiceCategory sc = new ServiceCategory();

        // GET: Produit
        public ActionResult Index()
        {
            var Products = sp.GetMany();
            return View(Products);
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
           // var Products = sp.GetMany(p=>p.Name == searchString);
            var Products = sp.GetMany(p => p.Name.Contains(searchString));
            return View(Products);
        }

        // GET: Produit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produit/Create
        public ActionResult Create()
        {
            ProductModel pm = new ProductModel();
            pm.Categories = sc.GetMany().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.CategoryId.ToString(),
            });
            
            return View(pm);
        }

        // POST: Produit/Create
        [HttpPost]
        public ActionResult Create(ProductModel pm)
        {
            try
            {
                // TODO: Add insert logic here
                Product p = new Product {
                    DateProd = pm.DateProd,
                    Name = pm.Name,
                    ImageName = pm.ImageName,
                    Price = pm.Price,
                    Quantity = pm.Quantity,
                    CategoryId = pm.CategoryId

                };
                sp.Add(p);
                sp.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produit/Edit/5
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

        // GET: Produit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produit/Delete/5
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
