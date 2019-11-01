using System;
using System.Collections.Generic;
using System.Linq;
using Shared.Models;

namespace WebAPIs.Repositories
{
    public class ConferenceMemoryRepo : IConferenceRepo
    {
        private readonly List<ConferenceModel> conferences = new List<ConferenceModel>();

        public ConferenceMemoryRepo()
        {
            conferences.Add(new ConferenceModel { Id = 1, Name = "DotNetConf", Location = "Quebec city", Start = new DateTime(2017, 6, 12), AttendeeTotal = 2132});
            conferences.Add(new ConferenceModel { Id = 2, Name = "Microsoft Ignite The Tour", Location = "Paris", Start = new DateTime(2017, 10, 18), AttendeeTotal = 3210});
        }
        public IEnumerable<ConferenceModel> GetAll()
        {
            return conferences;
        }

        public ConferenceModel GetById(int id)
        {
            return conferences.First(c => c.Id == id);
        }

        public ConferenceModel Add(ConferenceModel model)
        {
            model.Id = conferences.Max(c => c.Id) + 1;
            conferences.Add(model);
            return model;
        }
    }
}
