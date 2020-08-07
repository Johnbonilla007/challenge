using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeClientForm.Model
{
    public class ReviewRequest
    {
        public bool IsSealPresent { get; set; }
        public bool IsHazard { get; set; }
        public bool IsDamaggeFound { get; set; }
        public string Note { get; set; }
    }
}