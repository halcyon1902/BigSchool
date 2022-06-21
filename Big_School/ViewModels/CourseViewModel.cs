using Big_School.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Big_School.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            /*return DateTime.Parse(string.Format("{0} {1}", Date, Time));*/
            return DateTime.ParseExact(Date + " " + Time, "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
        }

        public IEnumerable<Course> UpCommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}