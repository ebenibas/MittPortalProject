using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MittJobPortalProject.Models
{
    public class Student:ApplicationUser
    {
        
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int Contact { get; set; }

        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<StudentJobPost> StudentJobPosts { get; set; }
    }
}