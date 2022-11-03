using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobManagementLibrary.DataAccess
{
    public partial class CandidateProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CandidateId { get; set; }
        public string Fullname { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string? ProfileShortDescription { get; set; } = null!;
        public string? ProfileUrl { get; set; } = null!;
        public int PostingId { get; set; }

        public virtual JobPosting Posting { get; set; } = null!;

    }
}
