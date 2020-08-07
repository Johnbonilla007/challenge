using Challenge.Net.Services.Infraestructure.Data.Data.Core;
using Challenge.Net.Services.Infraestructure.Data.DataContext.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Net.Services.Features.Review
{
    public interface IReviewAppService : IDisposable
    {
        ReviewDTO SaveReview(ReviewRequest request);
    }
}