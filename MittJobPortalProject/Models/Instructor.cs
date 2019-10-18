using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MittJobPortalProject.Models
{
    public class Instructor:ApplicationUser
    {

        public string Address { get; set; }

        public int Contact { get; set; }
    }
}