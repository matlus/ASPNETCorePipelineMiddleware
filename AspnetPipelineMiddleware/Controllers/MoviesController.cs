using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.DomainLayer;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DomainFacade _domainFacade = new DomainFacade();
        // GET api/movies
        [HttpGet]
        public IEnumerable<MovieResource> Get()
        {
            var movies = _domainFacade.GetAllMovies();
            return MapToMovieResource(movies);
        }

        // GET api/genre/Action
        [HttpGet("genre/{genreAsString}")]
        public IEnumerable<MovieResource> GetMoviesByGenre(string genreAsString)
        {
            var genre = GenreParser.Parse(genreAsString);
            var movies = _domainFacade.GetMoviesByGenre(genre);
            return MapToMovieResource(movies);
        }

        private static IEnumerable<MovieResource> MapToMovieResource(IEnumerable<Movie> movies)
        {
            foreach (var movie in movies)
            {
                yield return new MovieResource { Name = movie.Name, Genre = GenreParser.ToString(movie.Genre), ImageUrl = movie.ImageUrl, Year = movie.Year };
            }
        }
    }
}
