using AboutMe.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.Models.DataManager
{
    public class JobManager : IDataRepository<Job, long>
    {
        ApplicationContext ctx;
        public JobManager(ApplicationContext c)
        {
            ctx = c;
        }

        public Job Get(long id)
        {
            var student = ctx.Jobs.FirstOrDefault(b => b.Id == id);
            return student;
        }

        public IEnumerable<Job> GetAll()
        {
            var students = ctx.Jobs.ToList();
            return students;
        }


        public long Add(Job stundent)
        {
            ctx.Jobs.Add(stundent);
            long studentID = ctx.SaveChanges();
            return studentID;
        }

        public long Delete(long id)
        {
            int studentID = 0;
            var student = ctx.Jobs.FirstOrDefault(b => b.Id == id);
            if (student != null)
            {
                ctx.Jobs.Remove(student);
                studentID = ctx.SaveChanges();
            }
            return studentID;
        }

        public long Update(long id, Job item)
        {
            long studentID = 0;
            var student = ctx.Jobs.Find((int)id);

            if (student != null)
            {
                student.Title = item.Title;


                studentID = ctx.SaveChanges();
            }

            return studentID;
        }

    }
}
