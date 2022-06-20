using System;
using System.ComponentModel.DataAnnotations;

namespace Big_School.Models
{
    public class Course
    {
        public int Id
        {
            get; set;
        }

        public ApplicationUser Lecturer
        {
            get; set;
        }

        [Required]
        public string LecturerId
        {
            get; set;
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