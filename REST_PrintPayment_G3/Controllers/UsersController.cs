using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using REST_PrintPayment_G3.Models;
using BLL;


namespace REST_PrintPayment_G3.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        //to test :  http://localhost:2347/api/users/rt/ 
        [Route("uid/{uid}")]
        [HttpGet]
        public IHttpActionResult GetQuotaByUID(string uid)
        {
            float quota = UserManager.getQuotaByUID(uid);
            return Ok(quota);
        }

        //to test :  http://localhost:2347/api/users/ritinha/ 
        [Route("username/{username}")]
        [HttpGet]
        public IHttpActionResult GetQuotaByUsername(string username)
        {
            float quota = UserManager.getQuotaByUser(username);
            return Ok(quota);
        }

        /*
                //With GET method http://localhost:2347/api/users/ritinha/200/ 
                [Route("{username}/{quota:float}/")]
                [HttpGet]
                public IHttpActionResult EditUser(string username, float quota)
                {
                    bool result = UserManager.addQuotaByUsername(username, quota);
                    return Ok(result);
                }

                //With PUT method without object http://localhost:2347/api/users/ritinha/200/ 
                [Route("{username}/{quota:float}/")]
                [HttpPut]
                public IHttpActionResult EditUser2(string username, float quota)
                {
                    bool result = UserManager.addQuotaByUsername(username, quota);
                    return Ok(result);
                }

        */
        //With PUT method with object http://localhost:2347/api/users/ + RAW JSON {"Username":"ritina", "Credit":"200"}
        [Route("byusername")]
        [HttpPut]
        public IHttpActionResult EditUserByUsername([FromBody] User user)
        {
            float result = UserManager.addQuotaByUsername(user.Username, user.Credit);
            return Ok(result);
        }

        [Route("byuid")]
        [HttpPut]
        public IHttpActionResult EditUserByUid([FromBody] User user)
        {
            float result = UserManager.addQuotaByUID(user.Uid, user.Credit);
            return Ok(result);
        }

    }
}
