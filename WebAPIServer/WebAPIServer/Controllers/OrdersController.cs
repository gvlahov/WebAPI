using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIServer.Models;

namespace WebAPIServer.Controllers
{
    public class OrdersController : ApiController
    {
        // POST api/orders
        public Response Post([FromBody]Request request)
        {
            try
            {
                string test = request.apiToken.ToString()
                    + request.bcmContactInfo.firstName
                    + request.bcmContactInfo.middleName
                    + request.bcmContactInfo.lastName
                    ;

                return new Response { success = true };
            }
            catch (Exception ex)
            {
                return new Response { success = false, message = ex.Message };
            }
        }
    }
}