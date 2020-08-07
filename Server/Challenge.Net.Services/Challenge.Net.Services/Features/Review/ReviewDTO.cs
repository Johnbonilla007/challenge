using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Features.Review
{
    public class ReviewDTO
    {
        public bool IsSealPresent { get; set; }
        public bool IsHazard { get; set; }
        public bool IsDamaggeFound { get; set; }
        public string Note { get; set; }
        public string Message { get; set; }
    }
}