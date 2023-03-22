using _2011253453_NguyenQuocTuong.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace _2011253453_NguyenQuocTuong.ViewModels
{
    public class CourseViewModel
    {
        public int  Id{ get; set; }
        
        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }

        public byte Category { get; set; }
        public IEnumerable<Category> categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        

        public string Heading { get; set; }
        public string Action
        { 
            get { return (Id != 0) ? "Update" : "Create"; }
        }

    }
}