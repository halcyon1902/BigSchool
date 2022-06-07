using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Big_School.Models
{
    public class Course
    {
        public int Id
        {
            get;set;
        }
        public ApplicationUser Lecturrer
        {
            get;set;
        }
        [Required]
        public string LecturrerID
        {
            get;set;
        }
        [Required]
        [StringLength(225)]
        public string Place
        {
            get; set;
        }
        public DateTime DateTime
        {
            get; set;
        }
        public Category Category
        {
            get; set;
        }
        public byte CategoryId
        {
            get; set;
        }

    }
   
}