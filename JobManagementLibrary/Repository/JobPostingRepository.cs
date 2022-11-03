using JobManagementLibrary.DataAccess;
using JobManagementLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.Repository
{
    public class JobPostingRepository:IJobPostingRepository
    {
        public JobPosting GetJobPostingByID(int id) => JobPostingDAO.Instance.GetJobPostingByID(id);

        public IEnumerable<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetAllJobsPosting();

        public int GetJobPostingIdByTitle(string title) => JobPostingDAO.Instance.GetJobPostingIdFromTitle(title);
    }
}
