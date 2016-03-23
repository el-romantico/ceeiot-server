using SmartSigns.Services;
using System.Web.Http;

namespace SmartSigns.Controllers
{
    public class SignController : ApiController
    {
        [HttpGet]
        [Route("SignInfo/{signId}")]
        public IHttpActionResult GetInfo(string signId)
        {
            SignService service = new SignService();
            var info = service.GetSignInfo(signId);
            return Json(info);
        }
    }
}
