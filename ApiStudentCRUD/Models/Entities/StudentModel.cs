﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiStudentCRUD.Models.Entities
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}