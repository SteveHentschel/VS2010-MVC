using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuickRelational.Models
{
    public class MyAuthor
    {
        [Key]
        public int AuthorId { get; set; }
        [Required] //Anotation
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        // Author will have a collection of Books
    }
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }

        // Ref. for the Author . It helps to relate the two class
        // and also helps to create the EF Code First data Base
        public int AuthorId { get; set; }

        public virtual MyAuthor Author { get; set; } //virtual property to access MyAuthor

    }
}