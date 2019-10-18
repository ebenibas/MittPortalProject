using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MittJobPortalProject.Models
{
    public class Employer : ApplicationUser
    {
        public string CompanyName { get; set; }

        public string Address { get; set; }

        public int Contact { get; set; }
    }
}