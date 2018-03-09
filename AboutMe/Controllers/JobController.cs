using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboutMe.Models;
using Microsoft.AspNetCore.Mvc;

namespace AboutMe.Controllers
{
    [Route("api/[controller]")]
    public class JobController : Controller
    {
        [HttpGet("[action]")]
        public List<Job> Jobs()
        {
            List<Job> result = new List<Job>();

            result.Add( new Job()
                {
                    Id = 0001,
                    Title = "Google - Software Engineer",
                    Description = "Provide software support",
                    Category = "Software",
                    CompanyRate = "1 star",
                    Rate = "2 star",
                    Comment = "blah blah blah",
                    CreatedDate = "12/13/2018"
                }
            );

            result.Add(new Job()
                {
                    Id = 0002,
                    Title = "Yahoo - Software Engineer",
                    Description = "Provide software support",
                    Category = "Software",
                    CompanyRate = "1 star",
                    Rate = "2 star",
                    Comment = "blah blah blah",
                    CreatedDate = "12/13/2018"
                }
            );

            return result;
        }


        [HttpGet("[action]")]
        public Job JobDetail()
        {
            Job _job = new Job()
            {
                Id = 0002,
                Title = "Yahoo - Software Engineer",
                Description = "Provide software support",
                Category = "Software",
                CompanyRate = "1 star",
                Rate = "2 star",
                Comment = "blah blah blah",
                CreatedDate = "12/13/2018"
            };

            return _job;
        }

    }
}
