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
    public class AppointmentController : Controller
    {

        private IDataRepository<Appointment, long> _iRepo;
        public AppointmentController(IDataRepository<Appointment, long> repo)
        {
            _iRepo = repo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return _iRepo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return _iRepo.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Appointment test)
        {
            _iRepo.Add(test);
        }

        // PUT api/values
        [HttpPut]
        public void Put([FromBody]Appointment appointment)
        {
            _iRepo.Update(appointment.Id, appointment);
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public long Delete(int id)
        {
            return _iRepo.Delete(id);
        }
    }



    /*
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        
        [HttpGet("[action]")]
        public List<Event> Events()
        {
            List<Event> result = new List<Event>();

            result.Add( new Event()
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

            result.Add(new Event()
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
        public Event EventDetail(string Id)
        {
            Event _event = new Event();

            if (Id != "null")   // TODO: need to handle null and empty better
            {
                // TODO: get existing event
                _event = new Event()
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
           
            return _event;
        }

        [HttpPost("[action]")]
        public Event UpdateEvent([FromBody]Event event)
        {
            Event _event = new Event();

            if (event.Id == 0)
            {
                // TODO: insert new event
            }
            else
            {
                // TODO; update exiting event
            }

            return _event;
        }
        

    }
    */
}
