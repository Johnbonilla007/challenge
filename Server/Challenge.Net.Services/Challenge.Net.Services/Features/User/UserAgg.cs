using Challenge.Net.Services.Features.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Features.User
{
    public class UserAgg : Entity
    {
        public int Id { get; set; }
        public string UId { get; set; }
        public string Name { get; set; }
    }
}