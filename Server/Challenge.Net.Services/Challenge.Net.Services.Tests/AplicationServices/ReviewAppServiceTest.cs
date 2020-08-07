using Challenge.Net.Services.Features.Review;
using Challenge.Net.Services.Infraestructure.Data.Data.Core;
using Challenge.Net.Services.Infraestructure.Data.DataContext.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Net.Services.Tests.AplicationServices
{
    [TestClass]
    internal class ReviewAppServiceTest
    {
        private IReviewAppService _reviewAppService;

        public ReviewAppServiceTest()
        {
            //IGenericRepository<IGenericDataContext> _repository = new IQueryableUnitOfWork<IGenericDataContext>;

            //_reviewAppService = new ReviewAppService(_repository);
        }
    }
}