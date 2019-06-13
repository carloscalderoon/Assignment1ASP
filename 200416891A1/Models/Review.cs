using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _200416891A1.Models
{
    public class Review
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        [DisplayName("Review Description")]
        public string ReviewDescription { get; set; }
        [DisplayName("Number Of Stars")]
        public int Stars { get; set; }
        
        //public Review(String Name, String Subject, String ReviewDescription, int Stars)
        //{
        //    this.Name = Name;
        //    this.Subject = Subject;
        //    this.ReviewDescription = ReviewDescription;
        //    this.Stars = Stars;

        //    if (Stars < 0)
        //    {
        //        Stars = 0;
        //    }else if (Stars > 5){
        //        Stars = 5;
        //    }
        //}

    }
}