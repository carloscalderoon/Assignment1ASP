using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200416891A1.Models
{
    public class Genre
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        //public Genre(string Name, string Description)
        //{
        //    this.Name = Name;
        //    this.Description = Description;
        //}
    }
}