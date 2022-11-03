using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.DataAccess
{
    public class JobPostingDAO
    {
        private static JobPostingDAO instance = null;
        private static readonly object instanceLock = new object();
        public static JobPostingDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new JobPostingDAO();
                    }
                    return instance;
                }
            }
        }

        public JobPosting GetJobPostingByID(int id)
        {
            try
            {
                using var context = new JobManagementContext();
                var job = context.JobPostings.SingleOrDefault(job => job.PostingId == id);
                return job;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<JobPosting> GetAllJobsPosting()
        {
            List<JobPosting> list = new List<JobPosting>();
            try
            {
                using var context = new JobManagementContext();
                list = context.JobPostings.ToList();
                return list;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetJobPostingIdFromTitle(string title)
        {
            JobPosting jobPosting;
            try
            {
                using var context = new JobManagementContext();
                jobPosting = context.JobPostings.SingleOrDefault(job => job.JobPostingTitle.Contains(title));
                if( jobPosting != null)
                {
                    return jobPosting.PostingId;
                }
                else
                {
                    throw new Exception("Posting title does not exist");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }


}
