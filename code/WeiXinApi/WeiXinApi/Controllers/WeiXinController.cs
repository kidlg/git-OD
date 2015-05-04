using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeiXinApi.Controllers
{
    public class WeiXinController : ApiController
    {
        // GET: api/WeiXin
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WeiXin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WeiXin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WeiXin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WeiXin/5
        public void Delete(int id)
        {
        }

        private bool CheckSign()
        {
            return true;
        }
    }
}
