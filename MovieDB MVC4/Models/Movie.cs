using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MovieDB_MVC4.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

  //      [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class Movie1DBContext : DbContext
    {
        public DbSet<Movie> Movies1 { get; set; }
    }

}