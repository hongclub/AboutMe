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
            var job = ctx.Jobs.FirstOrDefault(b => b.Id == id);
            return job;
        }

        public IEnumerable<Job> GetAll()
        {
            var jobs = ctx.Jobs.ToList();
            return jobs;
        }


        public long Add(Job job)
        {
            ctx.Jobs.Add(job);
            long jobID = ctx.SaveChanges();
            return jobID;
        }

        public long Delete(long id)
        {
            int jobID = 0;
            var job = ctx.Jobs.FirstOrDefault(b => b.Id == id);
            if (job != null)
            {
                ctx.Jobs.Remove(job);
                jobID = ctx.SaveChanges();
            }
            return jobID;
        }

        public long Update(long id, Job item)
        {
            long jobID = 0;
            var job = ctx.Jobs.Find((int)id);

            if (job != null)
            {
                job.Title = item.Title;
                job.Comment = item.Comment;
                job.Rating = item.Rating;
                job.CompanyRating = item.CompanyRating;
                job.Category = item.Category;
                job.ModifiedDate = item.ModifiedDate;

                jobID = ctx.SaveChanges();
            }

            return jobID;
        }

    }
}
