using JobManagementLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.Repository.IRepository
{
    public interface ICandidateProfileRepository
    {
        IEnumerable<CandidateProfile> GetCandidateProfilesList();
        IEnumerable<CandidateProfile> SearchCandidateByFullname(string fullname);
        bool DeleteCandidateById(int id);

        bool AddNewCandidate(CandidateProfile cand);

        bool UpdateCandidate(CandidateProfile cand);


    }
}
