using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using WebAPIs.Repositories;

namespace WebAPIs.Controllers
{
    //[Route("v1/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class StatisticsController: ControllerBase
    {
        private readonly IStatisticsRepo repo;

        public StatisticsController(IStatisticsRepo repo)
        {
            this.repo = repo;
        }
        public StatisticsModel Get()
        {
            return repo.GetStatistics();
        }
    }
}
