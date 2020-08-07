using Challenge.Net.Services.Infraestructure.Data.Data.Core;
using Challenge.Net.Services.Infraestructure.Data.DataContext.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Features.User
{
    public class UserAppService : IUserAppService
    {
        private readonly IGenericRepository<IGenericDataContext> _repository;

        public UserAppService(IGenericRepository<IGenericDataContext> repository)
        {
            if (repository == null) throw new ArgumentNullException(nameof(repository));

            _repository = repository;
        }

        public UserDto ValidateCredentials(UserRequest request)
        {
            UserAgg user = _repository.GetSingle<UserAgg>(u => u.UId == request.UId && u.Name == request.Name);

            if (user != null)
            {
                return new UserDto { Message = "Granted Access!" };
            }

            return new UserDto { Message = "Access Denied!" };
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}