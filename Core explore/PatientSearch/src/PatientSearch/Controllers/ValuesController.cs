using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientSearch.Model;
using Microsoft.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace PatientSearch.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly PatientContext _context;

        public ValuesController(PatientContext ctx)
        {
            _context = ctx;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Patientinfo> Get()
        {
            var d= _context.Patients.FromSql("UAI_SearchPatients @UserName = N'IntPankajSiteMultiProv1',	@LastName = N'',@FirstName = N'',@ChartID = N'AHS',    @LicenseGUID = '5b22f265-6396-4279-9d34-db274c0b983c'");
            return d.ToList();
            //_context.Patients.FromSql("UAI_SearchPatients @UserName,@FirstName,@ChartID,@LicenseGUID", 
            //"IntPankajSiteMultiProv1","","","AHS", "5b22f265-6396-4279-9d34-db274c0b983c");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
