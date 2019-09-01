using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.DomainLayer
{
    public sealed class Movie
    {
        private readonly string _name;
        public string Name { get { return _name; } }

        private readonly Genre _genre;
        public Genre Genre { get { return _genre; } }

        private readonly int _year;
        public int Year { get { return _year; } }

        private readonly string _imageUrl;
        public string ImageUrl { get { return _imageUrl; } }

        public Movie(string name, Genre genre, int year, string imageUrl)
        {
            _name = name;
            _genre = genre;
            _year = year;
            _imageUrl = imageUrl;
        }
    }
}
