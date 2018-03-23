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
    public class UserController : Controller
    {

        private IDataRepository<User, long> _iRepo;
        public UserController(IDataRepository<User, long> repo)
        {
            _iRepo = repo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _iRepo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _iRepo.Get(id);
        }


        // PUT api/values
        [HttpPut]
        public void Put([FromBody]User user)
        {
            _iRepo.Update(user.Id, user);
        }



        //[Route("api/[controller]")]
        //public class UserController : Controller
        //{
        //    /*
        //    [HttpGet("[action]")]
        //    public List<string> UserDetail()
        //    {
        //        List<string> result = new List<string>();
        //        return result;
        //    }
        //    */

        //    [HttpGet("[action]")]
        //    public User UserDetail()
        //    {
        //        User _user = new User()
        //        {
        //            // TODO: get existing user
        //            Id = 1234,
        //            UserName = "hongclub",
        //            FirstName = "Tommy",
        //            LastName = "Lai",
        //            EmailAddress = "lai_tommy@hotmail.com",
        //            PhoneNumber = "9493743491"
        //        };

        //        return _user;
        //    }




        //}
    }
}
