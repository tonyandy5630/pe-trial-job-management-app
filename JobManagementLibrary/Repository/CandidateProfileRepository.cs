using JobManagementLibrary.DataAccess;
using JobManagementLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.Repository
{
    public class CandidateProfileRepository : ICandidateProfileRepository
    {
        public bool AddNewCandidate(CandidateProfile cand) => CandidateProfileDAO.Instance.AddCandidate(cand);

        public bool DeleteCandidateById(int id) => CandidateProfileDAO.Instance.DeleteACandidate(id);

        public IEnumerable<CandidateProfile> GetCandidateProfilesList() => CandidateProfileDAO.Instance.GetProfileList();

        public IEnumerable<CandidateProfile> SearchCandidateByFullname(string fullname) => CandidateProfileDAO.Instance.SearchCandidateByID(fullname);

        public bool UpdateCandidate(CandidateProfile cand) => CandidateProfileDAO.Instance.UpdateCandidate(cand);
    }
}
