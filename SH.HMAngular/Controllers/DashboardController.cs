using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SH.HMAngular.Models;

namespace SH.HMAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/Dashboard")]
    public class DashboardController : Controller
    {
        // GET: api/Dashboard
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public IEnumerable<Candidate> Get()
        {
            IList<Candidate> candidate = new List<Candidate>
            {
                new Candidate { CandidateId = 1, CandidateName = "Soumendra", Phone = "9999999999"},
                new Candidate { CandidateId = 2, CandidateName = "Asim", Phone = "9999999999"},
                new Candidate { CandidateId = 3, CandidateName = "Anil", Phone = "9999999999"},
                new Candidate { CandidateId = 4, CandidateName = "Abhinav", Phone = "9999999999"},
                new Candidate { CandidateId = 5, CandidateName = "Asutosasis", Phone = "9999999999"},
                new Candidate { CandidateId = 6, CandidateName = "Sakti", Phone = "9999999999"},
                new Candidate { CandidateId = 7, CandidateName = "Vidharva", Phone = "9999999999"},
                new Candidate { CandidateId = 8, CandidateName = "Rakesh", Phone = "9999999999"},
                new Candidate { CandidateId = 9, CandidateName = "Abhijit", Phone = "9999999999"},
                new Candidate { CandidateId = 10, CandidateName = "Om", Phone = "9999999999"},
                new Candidate { CandidateId = 11, CandidateName = "Kunal", Phone = "9999999999"},
                new Candidate { CandidateId = 12, CandidateName = "Soumendra", Phone = "9999999999"},
                new Candidate { CandidateId = 13, CandidateName = "Om", Phone = "9999999999"},
                new Candidate { CandidateId = 14, CandidateName = "Vidharva", Phone = "9999999999"},
                new Candidate { CandidateId = 15, CandidateName = "Pravat", Phone = "9999999999"},
                new Candidate { CandidateId = 16, CandidateName = "Vidharva", Phone = "9999999999"},
                new Candidate { CandidateId = 17, CandidateName = "Vidharva", Phone = "9999999999"},
                new Candidate { CandidateId = 18, CandidateName = "Vidharva", Phone = "9999999999"},
                new Candidate { CandidateId = 19, CandidateName = "Asutosasis", Phone = "9999999999"},
                new Candidate { CandidateId = 20, CandidateName = "Anil", Phone = "9999999999"}
            };


            return candidate;
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
