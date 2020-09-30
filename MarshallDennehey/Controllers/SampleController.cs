using MarshallDennehey.ViewModels;
using System.Web.Http;

namespace MarshallDennehey.Controllers
{
    [RoutePrefix("sample")]
    public class SampleController : ApiController
    {

        [HttpGet, Route("")]
        public string GetUser()
        {
            return "Kate";
        }

        [HttpPost, Route("")]
        public IHttpActionResult NewUser(UserVM user)
        {
            return Ok(user);
        }
    }
}
