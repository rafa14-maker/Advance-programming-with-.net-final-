using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoProjectWeb.Models
{
    public class Student
    {
        [Required]
        public string Name { set; get; }
        [Required]
        public string Dob { set; get; }
        [Required]
        public string Id { set; get; }
        [Required]
        public string Email { set; get; }
    }
}