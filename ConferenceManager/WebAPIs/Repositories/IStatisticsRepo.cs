using Shared.Models;

namespace WebAPIs.Repositories
{
    public interface IStatisticsRepo
    {
        StatisticsModel GetStatistics();
    }
}