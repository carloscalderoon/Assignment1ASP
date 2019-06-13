using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200416891A1.Models
{
    public class Videogame
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Minimum Requirements")]
        public string MinimumRequirements { get; set; }
        public Publisher Publishers { get; set; }
        public Developer Developers { get; set; }
        public Genre Genres { get; set; }
        public Review Reviews { get; set; }

        //public Videogame(int ID, String Name, Double Price, String Description, String MinimunRequierments, Publisher Publishers, Developer Developers,
        //    Genre Genres, Review Reviews)
        //{
        //    this.ID = ID;
        //    this.Name = Name;
        //    this.Price = Price;
        //    this.Description = Description;
        //    this.MinimumRequirements = MinimumRequirements;
        //    this.Publishers = Publishers;
        //    this.Developers = Developers;
        //    this.Genres = Genres;
        //    this.Reviews = Reviews;
        //}
    }
}