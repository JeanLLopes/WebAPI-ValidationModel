using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_ValidationModel.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult GetSportListDesktop([FromBody] GetSportListDesktopRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                //EXECUTE PROCESS
                return Json(request);
            }
            catch (Exception e)
            {
                BadRequest(e.Message);
                throw;
            }
        }

        [HttpPost]
        public IHttpActionResult GetSportMarketingList([FromBody] GetNextEventRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                //EXECUTE PROCESS
                return Json(request);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }  

        [HttpPost]
        public IHttpActionResult GetNextEvent([FromBody] GetNextEventRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                //EXECUTE PROCESS
                return Json(request);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
