using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SH.HMAngular.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string Phone { get; set; }
        //public Enum CandidateStatus { get; set; }
    }

    /// <summary>
    /// Scope of values can increase accordingly
    /// </summary>
    public enum CandidateStatus
    {
        L1 = 1,
        L2 = 2,
        L3 = 3,
        L4 = 4
    }
}
