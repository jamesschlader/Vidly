using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Models
{
    public class CustomerController : Controller

            {
               
        // GET: Customer
        public ActionResult Index()
        {

            var customer1 = new Customer() { Name = "George Costanza", Id = 1 };
            var customer2 = new Customer() { Name = "Betty Boop", Id = 2 };
            var customer3 = new Customer() { Name = "Sam Rockwell", Id = 3 };

            var Customers = new List<Customer>() {customer1, customer2, customer3};
            var ViewModel = new CustomerIndexViewModel
            { Customers = Customers};

            return View(ViewModel);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer1 = new Customer() { Name = "George Costanza", Id = 1 };
            var customer2 = new Customer() { Name = "Betty Boop", Id = 2 };
            var customer3 = new Customer() { Name = "Sam Rockwell", Id = 3 };
            switch (id)
            {
                case 1:
                    return View(customer1);
                case 2:
                    return View(customer2);
                case 3:
                    return View(customer3);
                default:
                    return View(customer1);

            }
            
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}