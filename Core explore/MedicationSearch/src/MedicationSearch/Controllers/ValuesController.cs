using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccess;

namespace MedicationSearch.Controllers
{
 
    public class MedsController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("api/meds/{name}")]
        public IEnumerable<string> Get(string name)
        {
            var x = DBHelper.QueryMeds(name, 200, "");
            return x;
        }
       
    }
}
