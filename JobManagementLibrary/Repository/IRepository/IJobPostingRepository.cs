using JobManagementLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.Repository.IRepository
{
    public interface IJobPostingRepository
    {
        JobPosting GetJobPostingByID(int id);
        IEnumerable<JobPosting> GetJobPostings();
        int GetJobPostingIdByTitle(string title);


    }
}
