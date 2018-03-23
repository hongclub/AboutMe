using AboutMe.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.Models.DataManager
{
    public class UserManager : IDataRepository<User, long>
    {
        ApplicationContext ctx;
        public UserManager(ApplicationContext c)
        {
            ctx = c;
        }

        public User Get(long id)
        {
            var user = ctx.Users.FirstOrDefault(b => b.Id == id);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            var users = ctx.Users.ToList();
            return users;
        }

        public long Add(User user)
        {
            throw new System.NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new System.NotImplementedException();
        }



        public long Update(long id, User item)
        {
            long userID = 0;
            var user = ctx.Users.Find((int)id);

            if (user != null)
            {
                user.PhoneNumber = item.PhoneNumber;


                userID = ctx.SaveChanges();
            }

            return userID;
        }

    }
}
