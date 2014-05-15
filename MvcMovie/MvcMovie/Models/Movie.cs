using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity; // for use by Entity Framework for MovieDBContext

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)] // You can also make the date culture specific like this
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
        // Because you've added a new field to the Movie class, you also need
        // to update the the binding white list so this new property will be included.
        // Update the bind attribute for Create and Edit action methods to include the Rating property
        // You also need to update the view templates in order to display, create and edit the new Rating property in the browser view
    }

    // The MovieDBContext class represents the Entity Framework movie database context,
    // which handles fetching, storing, and updating Movie class instances in a database.
    // The MovieDBContext derives from the DbContext base class provided by the Entity Framework.
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}