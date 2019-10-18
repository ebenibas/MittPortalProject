using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MittJobPortalProject.Models
{
    public class JobPost
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int EmployerId { get; set; }
        public virtual Employer Employer { get; set; }
        public int RoundId { get; set; }
        public virtual Round Round { get; set; }
        public string CompanyAddress { get; set; }
        public string Position { get; set; }
        public DateTime Posted { get; set; }
        public string Description { get; set; }


        public virtual ICollection<StudentJobPost> StudentJobPosts { get; set; }

    }
}