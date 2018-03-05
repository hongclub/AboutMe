using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AboutMe.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        [HttpGet("[action]")]
        public List<string> UserDetail()
        {
            List<string> result = new List<string>();
            return result;
        }


    }
}
