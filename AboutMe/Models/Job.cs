using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.Models
{
    public class Job
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Comment { get; set; }

        public string Rate { get; set; }

        public string CompanyRate { get; set; }

        public string Category { get; set; }

        public string CreatedDate { get; set; }


    }
}
