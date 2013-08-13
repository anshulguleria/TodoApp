using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace ToDoApp.Controllers
{
    public class AccountController : ApiController
    {
        // GET {userName}/Home
        [HttpGet]
        public string Home()
        {
            return string.Format("Got request");
        }

        // POST {userName}/Search
        [HttpPost]
        public string Search([FromBody]string value)
        {
            return string.Format("Posted data: {0}", value);
        }

        // PUT {userName}/Update/5
        [HttpPut]
        public string Update(string id, [FromBody]string value)
        {
            return string.Format("Id: {0}, New Value: {1}", id, value);
        }

        // DELETE {userName}/Delete/5
        [HttpDelete]
        public string Delete(string id)
        {
            return string.Format("Delete data: {0}", id);
        }
    }
}
