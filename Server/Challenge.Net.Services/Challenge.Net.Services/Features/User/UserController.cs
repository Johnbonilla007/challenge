using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Challenge.Net.Services.Features.User
{
    [RoutePrefix(@"api/v1/users")]
    public class UserController : ApiController
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            if (userAppService == null) throw new ArgumentNullException(nameof(userAppService));

            _userAppService = userAppService;
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult ValidateCredentials(UserRequest request)
        {
            UserDto response = _userAppService.ValidateCredentials(request);

            return Ok(response);
        }
    }
}