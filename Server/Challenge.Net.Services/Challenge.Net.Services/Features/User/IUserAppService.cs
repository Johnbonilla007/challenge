using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Net.Services.Features.User
{
    public interface IUserAppService : IDisposable
    {
        UserDto ValidateCredentials(UserRequest request);
    }
}