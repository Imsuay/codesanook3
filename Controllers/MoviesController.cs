using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanookMovie.Models;

namespace SanookMovie.Controllers
{
    public class MoviesController : Controller
    {
        static IList<Movies> _movies = new List<Movies>();
        
        public MoviesController()
        {
            // _movies.Add("Titanic");
            // _movies.Add("Avengers");
            // _movies.Add("Alita");
        }
        
        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movies movie)
        {
            _movies.Add(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);
            if (movie == null){
                return NotFound();
            }
            return View(movie);
        }

        public IActionResult DeleteConfirm(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);
            if (movie == null){
                return NotFound();
            }

            _movies.Remove(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail()
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
