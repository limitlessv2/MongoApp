using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MongoApp.Controllers
{
    public class BaseController : Controller
    {
        [HttpGet]
        [Route("api/v1/base/{id}")]
        public string Get(int id){
            return "GET for : " + id;
        }

        [HttpPost]
        [Route("api/v1/base/{id}")]
        public string Post(int id){
            return "Post for : " + id;
        }

        [HttpDelete]
        [Route("api/v1/base/{id}")]
        public string Delete(int id){
            return "Delete for : " + id;
        }

        [HttpPut]
        [Route("api/v1/base/{id}")]
        public string Put(int id){
            return "GET for : " + id;
        }

        /// <summary>
        /// Create a Obj
        /// </summary>
        /// <param name="obj">The Obj object to be created</param>
        /// <returns>The newly created Obj</returns>
        [HttpPost]
        [Route("api/v1/base/obj")]
        public Obj PostObj([FromBody] Obj obj){
            return obj;
        }

        public class Obj{
            public int id {get;set;}
            public string name {get;set;}
        }
    }
}
