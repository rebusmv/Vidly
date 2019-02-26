﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public Genre Genre { get; set; }
        [Required]
        [Display(Name="Genre")]
        public byte GenreId { get; set; }
        [Required]
        [Display(Name="Date Added")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(minimum:1,maximum:20,ErrorMessage = "The field Number in Stock must be between 1 and 20")]
        public byte NumberInStock { get; set; }
    }   
}