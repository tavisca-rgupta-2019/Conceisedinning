using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConceiseDinning.Core.Models;
using ConceiseDinning.Core.Translator;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ConceiseDinning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestrauntSearchController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetRestarauntDetailsByLocalty(string LocalityVerbose)
        {
            RestrauntFinderForTableBooking Find = new RestrauntFinderForTableBooking();
            var result = Find.GetRestarauntDetails(LocalityVerbose);

            return result.Latitude==0.00?new string[]{"false"}:new string[] { "true" };
        }
    }
}