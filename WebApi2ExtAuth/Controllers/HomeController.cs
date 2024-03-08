using System.Net.Http;
using System.Web.Http;

namespace WebApi2ExtAuth.Controllers
{
    [Authorize]
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            var user = Request.GetOwinContext().Authentication.User;
            return Ok("Welcome, " + user.Identity.Name);
        }
    }
}
