using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace RunKeeper.Controllers
{
    public class ActivityController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        public async Task<IHttpActionResult> GetAllValues()
        {
            var runs = await this.RetrieveRunningActivities();

            return this.Ok(runs);

        }
        private async Task<IEnumerable<RunKeeper.Models.ActivityModel>> RetrieveRunningActivities()
        {
            var csv = new CsvReader(new StreamReader("Actors.csv"));
            var activities = csv.GetRecords<RunKeeper.Models.ActivityModel>();

            return await activities;
        } 
    }
}