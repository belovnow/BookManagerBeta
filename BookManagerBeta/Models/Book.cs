using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookManagerBeta.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Please enter book's title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter book's author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter book's description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter book's number of pages")]
        public ushort? Pages { get; set; }
        //public int PagesRead { get; set; } = 0;
    }
}
