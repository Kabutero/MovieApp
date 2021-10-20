using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieAppProject.Models;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;

namespace MovieAppProject.Controllers
{
    public class HomeController : Controller
    {
        private IMovieService _movieService;
        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        //https://localhost/home/index
        [HttpGet]
        public IActionResult Index()
        {
            //call movie service class to get list of movie card models
            var movieCards = _movieService.GetTop30RevenueMovies();
            //passing data from controller to view, strongly typed models (preferred way)
            //ViewBag AND ViewData
            return View(movieCards);
        }

        //https://localhost/home/privacy
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
