using Challenge.Net.Services.Infraestructure.Data.Data.Core;
using Challenge.Net.Services.Infraestructure.Data.DataContext.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Features.Review
{
    public class ReviewAppService : IReviewAppService
    {
        private readonly IGenericRepository<IGenericDataContext> _repository;

        public ReviewAppService(IGenericRepository<IGenericDataContext> repository)
        {
            if (repository == null) throw new ArgumentNullException(nameof(repository));

            _repository = repository;
        }

        public ReviewDTO SaveReview(ReviewRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            ReviewAgg review = MaterializeReview(request);

            _repository.Add(review);
            _repository.UnitOfWork.Commit();

            return new ReviewDTO { Message = "Success!" };
        }

        private ReviewAgg MaterializeReview(ReviewRequest request)
        {
            return new ReviewAgg
            {
                IsSealPresent = request.IsSealPresent,
                IsHazard = request.IsHazard,
                IsDamaggeFound = request.IsDamaggeFound,
                Note = request.Note
            };
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}