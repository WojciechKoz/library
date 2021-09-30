using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The title of the book is mandatory.")]
        [Display(Name = "Title")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The author of the book is mandatory.")]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "The Release date of the book is mandatory.")]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "The description of the book is mandatory.")]
        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}
