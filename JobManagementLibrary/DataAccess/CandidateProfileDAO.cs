using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.DataAccess
{
    public class CandidateProfileDAO
    {

        private static CandidateProfileDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CandidateProfileDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CandidateProfileDAO();
                    }
                    return instance;
                }
            }
        }

        public CandidateProfile GetCandidateProfileByID(int id)
        {
            try
            {
                using var context = new JobManagementContext();
                var cand = context.CandidateProfiles.SingleOrDefault(cand => cand.CandidateId == id);
                return cand;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<CandidateProfile> GetProfileList()
        {
            List<CandidateProfile> list = new List<CandidateProfile>();
            try
            {
                using var context = new JobManagementContext();
                //var allCandidates = from cand in context.CandidateProfiles
                //                    join post in context.JobPostings
                //                    on cand.PostingId equals post.PostingId
                //                    select new CandidateProfile{ CandidateId = cand.CandidateId, Birthday = cand.Birthday, Fullname = cand.Fullname};
                list = context.CandidateProfiles.ToList();

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<CandidateProfile> SearchCandidateByID(string fullname)
        {
            List<CandidateProfile> list = new List<CandidateProfile>();
            try
            {
                using var context = new JobManagementContext();
                var allCandidates = from cand in context.CandidateProfiles
                                    join post in context.JobPostings
                                    on cand.PostingId equals post.PostingId
                                    where cand.Fullname.Contains(fullname)
                                    select new CandidateProfile
                                    {
                                        CandidateId = cand.CandidateId,
                                        Birthday = cand.Birthday,
                                        Fullname = cand.Fullname,
                                        ProfileShortDescription = cand.ProfileShortDescription,
                                        ProfileUrl = cand.ProfileUrl,
                                        PostingId = cand.PostingId,
                                    };
                list = allCandidates.ToList();
                if (list == null || list.Count() == 0)
                {
                    throw new Exception("Name not existed");
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteACandidate(int id)
        {
            CandidateProfile candidateProfile = GetCandidateProfileByID(id);
            try
            {
                if (candidateProfile != null)
                {
                    using var context = new JobManagementContext();
                    context.CandidateProfiles.Remove(candidateProfile);
                    return context.SaveChanges() == 1;
                }
                else
                {
                    throw new Exception("Candidate not exist");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AddCandidate(CandidateProfile aCand)
        {
            CandidateProfile cand = GetCandidateProfileByID(aCand.CandidateId);
            try
            {

                if (cand != null)
                {
                    throw new Exception("Candidate already exsited");
                }
                using var context = new JobManagementContext();
                context.CandidateProfiles.Add(aCand);
                return context.SaveChanges() == 1;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateCandidate(CandidateProfile cand)
        {
            CandidateProfile uCand = GetCandidateProfileByID(cand.CandidateId);
            try
            {
                if (uCand != null)
                {
                    using var context = new JobManagementContext();
                    context.CandidateProfiles.Update(cand);
                    return context.SaveChanges() == 1;
                }
                else
                {
                    throw new Exception("Candidate profile not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
