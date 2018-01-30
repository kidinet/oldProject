
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Web.Script.Serialization;
using DatabaseFirstSample;
using System.Data.Entity;
using System.Net.Mail;

namespace WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api")]
    public class UserlController : BaseController
    {
        BL_User bl_user = new BL_User();
       
        [HttpGet]
        [Route("createUser/{Language}/{Registered}")]
        public IHttpActionResult createUser(
            string Language,
            bool Registered,
            string mail,
            string firstName,
            string lastName,
            string childFirstName,
            string childLastName,
            string nickName,
            byte[] profile,
            string password,
            string city,
            string streat,
            int build,
            string phone,
            bool isAdministrator,
            int groupId)
        {
           // http://localhost:7022/api/createUser/he/true?&mail=vbnmvb&firstName=fgjfg&lastName=gfjfghj&childFirstName=undefinednickName=undefinedprofile=null&password=mm&city=gfjfg&build=7&street=fgjfgh&phone=mbvnm&isAdministrator=true&groupId=120
            //localhost:7022/api/createUser/he/true?&mail=ghjghj@kjkjk3333j.com&firstName=12334&lastName=dADSASD&childFirstName=undefined&childLastName=undefined&nickName=undefined&profile=undefined&password=1&city=sdfsda&build=3&streat=dsfa&phone=0588822808&isAdministrator=true&groupId=100
            return Ok(bl_user.createUser(
                        mail,
                        firstName,
                        lastName,
                        childFirstName,
                        childLastName,
                        nickName,
                        profile,
                        password,
                        city,
                        streat,
                        build,
                        phone,
                        isAdministrator,
                        groupId)
                        );
        }
    }
}
