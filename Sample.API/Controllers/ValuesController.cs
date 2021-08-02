using Sample.Core;
using Sample.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var result = new Result<int>();

            try
            {
                if (id > 5)
                {
                    result.HasData = false;
                    result.Error = new My502Exception(23434, "This is my 501");

                    return ResponseMessage(Request.CreateResponse(HttpStatusCode.NotImplemented, result));
                }
            }
            catch (Exception ex)
            {
                
            }

            result.HasData = true;
            result.Data = id;

            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, result));
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
