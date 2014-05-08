using System;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    // The MovieDBContext class represents the Entity Framework movie database context,
    // which handles fetching, storing, and updating Movie class instances in a database.
    // The MovieDBContext derives from the DbContext base class provided by the Entity Framework.
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}