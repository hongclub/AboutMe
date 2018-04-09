using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboutMe.Models;
using AboutMe.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AboutMe.Controllers
{
    [Route("api/[controller]")]
    public class JobController : Controller
    {

        private IDataRepository<Job, long> _iRepo;
        public JobController(IDataRepository<Job, long> repo)
        {
            _iRepo = repo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Job> Get()
        {
            return _iRepo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Job Get(int id)
        {
            return _iRepo.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Job job)
        {
            _iRepo.Add(job);
        }

        // PUT api/values
        [HttpPut]
        public void Put([FromBody]Job job)
        {
            _iRepo.Update(job.Id, job);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public long Delete(int id)
        {
            return _iRepo.Delete(id);
        }


        /*
        [HttpGet("{id}")]
        public object GetJobOption()
        {
            return _iRepo.Get(id);
        }
        */
    }



    /*
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


        [HttpGet("[action]/{Id}")]
        public Job JobDetail(string Id)
        {
            Job _job = new Job();

            if (Id != "null")   // TODO: need to handle null and empty better
            {
                // TODO: get existing job
                _job = new Job()
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
            }
           
            return _job;
        }

        [HttpPost("[action]")]
        public Job UpdateJob([FromBody]Job job)
        {
            Job _job = new Job();

            if (job.Id == 0)
            {
                // TODO: insert new job
            }
            else
            {
                // TODO; update exiting job
            }

            return _job;
        }
        

    }
    */
}
