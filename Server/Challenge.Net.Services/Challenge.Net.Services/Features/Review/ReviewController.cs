using Challenge.Net.Services.Features.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Challenge.Net.Services.Features
{
    [RoutePrefix(@"api/v1/reviews")]
    public class ReviewController : ApiController
    {
        private readonly IReviewAppService _reviewAppService;

        public ReviewController(IReviewAppService reviewAppService)
        {
            if (reviewAppService == null) throw new ArgumentNullException(nameof(reviewAppService));

            _reviewAppService = reviewAppService;
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult SaveReview(ReviewRequest request)
        {
            ReviewDTO response = _reviewAppService.SaveReview(request);

            return Ok(response);
        }
    }
}