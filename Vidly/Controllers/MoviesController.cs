using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{

    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);
        }

        public IActionResult Edit(int id)
        {
           
            return Content("id = " + id);
        }

        [Route("movies")]

        public IActionResult List()
        {

            var movie1 = new Movie() { Id = 1, Name = "Shrek"};
            var movie2 = new Movie() { Id = 2, Name = "Star Wars" };
            var movie3 = new Movie() { Id = 3, Name = "Lost in Space" };

            var movies = new List<Movie>() { movie1, movie2, movie3 };
            var movieView = new ViewMoviesViewModel { Movies = movies };
            return View(movieView);
        }
        
    }
}