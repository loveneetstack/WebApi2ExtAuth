using System.Web.Http;
using WebApi2ExtAuth.Common;

namespace WebApi2ExtAuth.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ExternalLogin()
        {
            return new ChallengeResult("Google", "/api/home", this.Request);
        }
    }
}
