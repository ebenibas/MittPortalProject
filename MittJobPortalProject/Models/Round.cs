using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MittJobPortalProject.Models
{
    public class Round
    {
        public int Id { get; set; }
        public string Session { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}