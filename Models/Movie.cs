using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Movie
    {
        [Required]
        public string Category { get; set; }
        [Required]        
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        /* Optional inputs */
        public string Edit { get; set; }
        public string LendTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
