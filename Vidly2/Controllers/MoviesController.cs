﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer{ Name = "Cust1" },
                new Customer{ Name = "Cust2" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);

            //return View(movie);
            //return Content("Hello World!!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        ////Using ViewBag
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    ViewBag.Movie = movie;
        //    return View();
        //}

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //// GET: Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex={0} and sortBy={1}", pageIndex, sortBy));
        //}

        // GET: Movies
        public ActionResult Index()
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie() { Id = 1, Name = "Shrek" },
                new Movie() { Id = 2, Name = "Wall-E" }
            };

            return View(movieList);
        }

        // GET: movies/released
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}