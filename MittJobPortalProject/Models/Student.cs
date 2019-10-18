﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MittJobPortalProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string AppliacationUserId { get; set; }
        public virtual ApplicationUser StudentName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int Contact { get; set; }

        public string  ApplicationUserId { get; set; }
        public virtual ApplicationUser Instructor { get; set; }

        public virtual ICollection<StudentJobPost> StudentJobPosts { get; set; }
    }
}