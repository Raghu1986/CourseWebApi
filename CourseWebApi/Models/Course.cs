using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseWebApi.Models
{
    public class Course
    {
        [Key]

        public int Id { get; set; }

        public string CourseType { get; set; }
        public string LogoUri { get; set; }

    }
}