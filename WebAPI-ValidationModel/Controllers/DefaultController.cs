using System;
using System.Web.Http;
using WebAPI_ValidationModel.Models;

namespace WebAPI_ValidationModel.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult GetSportListDesktop([FromBody] GetSportListDesktopRequest request)
        {
            try
            {
                //Esse check para o ModelState.IsValid poderia ser refatorado e não ter a 
                //necessidade de repetir ele toda vez, o que realmente importa para o 
                //nosso controller é o return do Json e só! Para resolver esse problema: 
                //podemos fazer da seguinte forma:
                //if (!ModelState.IsValid)
                //{
                //    return BadRequest(ModelState);
                //}

                //EXECUTE PROCESS
                return Json(request);
            }
            catch (Exception e)
            {
                BadRequest(e.Message);
                throw;
            }
        }

        //Esse check para o ModelState.IsValid poderia ser refatorado e não ter a 
        //necessidade de repetir ele toda vez, o que realmente importa para o 
        //nosso controller é o return do Json e só! Para resolver esse problema: 
        //podemos fazer da seguinte forma:
        [HttpPost]
        [ModelStateValidationActionFilter]
        public IHttpActionResult GetSportMarketingList([FromBody] GetNextEventRequest request)
        {
            try
            {
                //Esse check para o ModelState.IsValid poderia ser refatorado e não ter a 
                //necessidade de repetir ele toda vez, o que realmente importa para o 
                //nosso controller é o return do Json e só! Para resolver esse problema: 
                //podemos fazer da seguinte forma:
                //if (!ModelState.IsValid)
                //{
                //    return BadRequest(ModelState);
                //}

                //EXECUTE PROCESS
                return Json(request);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }  

        [HttpPost]
        [ModelStateValidationActionFilter]
        public IHttpActionResult GetNextEvent([FromBody] GetNextEventRequest request)
        {
            try
            {
                //Esse check para o ModelState.IsValid poderia ser refatorado e não ter a 
                //necessidade de repetir ele toda vez, o que realmente importa para o 
                //nosso controller é o return do Json e só! Para resolver esse problema: 
                //podemos fazer da seguinte forma:
                //if (!ModelState.IsValid)
                //{
                //    return BadRequest(ModelState);
                //}

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
