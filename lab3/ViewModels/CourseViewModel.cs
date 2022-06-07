using lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.ViewModels
{
    public class CourseViewModel
    {
        [required]
        public string Place { get; set; }
        [required]
        [FutureDate]
        public string Date { get; set; }
        [required]
        [ValidTime]
        public string Time { get; set; }
        [required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}