using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SH.HMAngular.Models;
using SH.HMAngular.Services;

namespace SH.HMAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/Dashboard")]
    public class DashboardController : Controller
    {
        private IDashboardService _dashboardSvc;
        public DashboardController(IDashboardService dashboardSvc)
        {
            _dashboardSvc = dashboardSvc;
        }

        // GET: api/Dashboard
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public IEnumerable<Candidate> Get()
        {
            return _dashboardSvc.GetCandidate();
        }

        // GET: api/Dashboard/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Dashboard
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dashboard/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
