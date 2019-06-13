using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200416891A1.Models
{
    public class Developer
    {
        [Required]
        public string Name { get; set; }
        public string Website { get; set; }

        //public Developer(String Name, String Website)
        //{
        //    this.Name = Name;
        //    this.Website = Website;
        //}
    }
}