using System.Linq;
using Shared.Models;

namespace WebAPIs.Repositories
{
    public class StatisticsMemoryRepo : IStatisticsRepo
    {
        private readonly IConferenceRepo conferenceRepo;

        public StatisticsMemoryRepo(IConferenceRepo conferenceRepo)
        {
            this.conferenceRepo = conferenceRepo;
        }

        public StatisticsModel GetStatistics()
        {
            var conferences = conferenceRepo.GetAll();
            return new StatisticsModel
            {
                NumberOfAttendees = conferences.Sum(c => c.AttendeeTotal),
                AverageConferenceAttendees = (int)conferences.Average(c => c.AttendeeTotal)
            };
        }
    }
}
