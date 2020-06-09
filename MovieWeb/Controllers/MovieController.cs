using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieWeb.Domain;
using System.Reflection.Metadata.Ecma335;
using MovieWeb.Models;
using MovieWeb.Database;

namespace MovieWeb.Controllers
{
    
    public class MovieController : Controller
    {
        private readonly IMovieDatabase _movieDatabase;

        public MovieController(IMovieDatabase movieDatabase)
        {
            _movieDatabase = movieDatabase;
        }
        
        public IActionResult Detail(int id)
        {
            Movie movieFromDb = _movieDatabase.GetMovie(id);

            MovieDetailViewModel movie = new MovieDetailViewModel()            
            {
                Title = movieFromDb.Title,
                Description = movieFromDb.Description,
                Genre = movieFromDb.Genre,
                Releasedate = movieFromDb.Releasedate
            };

            return View(movie);        
        }
       
        public IActionResult Index()
        {
            IEnumerable<Movie> moviesFromDb = _movieDatabase.GetMovies();
            List<MovieListViewModel> movies = new List<MovieListViewModel>();

            foreach (Movie movie in moviesFromDb)
            {
                movies.Add(new MovieListViewModel() { Id = movie.Id, Title = movie.Title });
            }

            return View(movies);
        }
        public IActionResult Create()
        {
            MovieCreateViewModel vm = new MovieCreateViewModel();
            vm.Releasedate = DateTime.Now;
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(MovieCreateViewModel movie)
        {
            if (!TryValidateModel(movie))
            {
                return View(movie);
            }
            Movie newMovie = new Movie()
            {
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                Releasedate = movie.Releasedate
            };

            _movieDatabase.Insert(newMovie);

            return RedirectToAction("Index");
        }
       public IActionResult Edit(int id)
        {
            Movie movieFromDb = _movieDatabase.GetMovie(id);
            MovieEditViewModel vm = new MovieEditViewModel()
            {
                Title = movieFromDb.Title,
                Description = movieFromDb.Description,
                Releasedate = movieFromDb.Releasedate,
                Genre = movieFromDb.Genre
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Edit(int id, MovieEditViewModel vm)
        {
            if (!TryValidateModel(vm))
            {
                return View(vm);
            }

            Movie domainMovie = new Movie()
            {
                Id = id,
                Title = vm.Title,
                Description = vm.Description,
                Genre = vm.Genre,
                Releasedate = vm.Releasedate
            };

            _movieDatabase.Update(id, domainMovie);

            return RedirectToAction("Detail", new { Id = id });
        }

    }
}
