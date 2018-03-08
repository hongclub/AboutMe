using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboutMe.Models;
using Microsoft.AspNetCore.Mvc;

namespace AboutMe.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        /*
        [HttpGet("[action]")]
        public List<string> UserDetail()
        {
            List<string> result = new List<string>();
            return result;
        }
        */

        [HttpGet("[action]")]
        public User UserDetail()
        {
            User _user = new User()
            {
                Id = 1234,
                UserName = "hongclub",
                FirstName = "Tommy",
                LastName = "Lai",
                EmailAddress = "lai_tommy@hotmail.com",
                PhoneNumber = "9493743491"
            };

            return _user;
        }




    }
}
