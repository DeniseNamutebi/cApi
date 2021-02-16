using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiWorkshop.Controllers
{
    public class DataController : ApiController
    {
        [HttpGet] [Route("api/customer")]
        public IHttpActionResult GetCustomer(int id)
        {
            Services.DataService service = new Services.DataService();

            return Ok(service.GetCustomer(id));
        }

        [HttpPost] [Route("api/customer")]
        public IHttpActionResult UpdateCustomer([FromBody] Models.Customer customer)
        {
            Services.DataService service = new Services.DataService();
            return Ok(service.UpdateCustomer(customer));
        }

        
        [HttpGet] [Route("api/customers")]
        public IHttpActionResult ListCustomers()
        {
            Services.DataService service = new Services.DataService();
            return Ok(service.ListCustomers());

        }
    }
}
