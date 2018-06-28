using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SkyWalking.Sample.Backend.Models;

namespace SkyWalking.Sample.Backend.Controllers
{
    [Route("api/[controller]")]
    public class AppsController : Controller
    {
        private readonly SampleDbContext _dbContext;

        public AppsController(SampleDbContext sampleDbContext)
        {
            _dbContext = sampleDbContext;
        }
        // GET api/apps
        [HttpGet]
        public IEnumerable<Application> Get()
        {
            return _dbContext.Applications.ToList();
        }
        //GET api/apps/5
        [HttpGet("{id}")]
        public Application Get(int id)
        {
            return _dbContext.Applications.Find(id);
        }

        // PUT api/apps
        [HttpPut]
        public string Put([FromBody]Application application)
        {
            _dbContext.Applications.Add(application);
            _dbContext.SaveChanges();
            return "1";
        }
    }
}