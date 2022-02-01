using System;
using System.ComponentModel.DataAnnotations;

namespace Mission4ASP.Models
{
    public class MoviesResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        // Build a foreign key relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
