using System;
using System.Collections.Generic;

namespace JobManagementLibrary.DataAccess
{
    public partial class JobPosting
    {
        public JobPosting()
        {
            CandidateProfiles = new HashSet<CandidateProfile>();
        }

        public int PostingId { get; set; }
        public string JobPostingTitle { get; set; } = null!;
        public string Description { get; set; } = null!;

        public DateTime PostedDate { get; set; }

        public virtual ICollection<CandidateProfile> CandidateProfiles { get; set; }
    }
}
