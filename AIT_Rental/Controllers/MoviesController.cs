﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIT_Rental.Models;

namespace AIT_Rental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "dangal" };

            //return View(movie);
            return RedirectToAction("Index","Home", new { page =1 , sortBy ="name"});
        }
        public ActionResult Edit(int MovieId)
        {
            return Content("id=" + MovieId);
        }
        public ActionResult Index(int? pageIndex, string sortBy) 
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        
        }
        public ActionResult ByReleaseDate(int year, int month) {
            return Content(year+"/"+month);
         }

    }
}