﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETKata.Models;

namespace ASPNETKata.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()

        {
            var list = new List<Person>();
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Jack"});
            list.Add(new Person {Age = 15, IsMinor = true, Name = "John" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Josh" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Zack" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Brian" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Will" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Guss" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Maddie" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Liz" });
            list.Add(new Person {Age = 15, IsMinor = true, Name = "Ann" });
            
            return View(list);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
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

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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
