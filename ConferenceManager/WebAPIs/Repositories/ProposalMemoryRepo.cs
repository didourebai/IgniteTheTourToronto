using System.Collections.Generic;
using System.Linq;
using Shared.Models;

namespace WebAPIs.Repositories
{  
    public class ProposalMemoryRepo : IProposalRepo
    {
        private readonly List<ProposalModel> proposals = new List<ProposalModel>();

        public ProposalMemoryRepo()
        {
            proposals.Add(new ProposalModel
            {
                Id = 1,
                ConferenceId = 1,
                Speaker = "Hamida Rebai",
                Title = "Deployer dans Microsoft Azure"
            });
            proposals.Add(new ProposalModel
            {
                Id = 2,
                ConferenceId = 2,
                Speaker = "Rayen Trabelsi",
                Title = "Minecraft"
            });
            proposals.Add(new ProposalModel
            {
                Id = 3,
                ConferenceId = 2,
                Speaker = "Hamida Trabelsi",
                Title = "ASP.NET Core"
            });
        }

        public IEnumerable<ProposalModel> GetAllForConference(int conferenceId)
        {
            return proposals.Where(p => p.ConferenceId == conferenceId);
        }

        public ProposalModel Add(ProposalModel model)
        {
            model.Id = proposals.Max(p => p.Id) + 1;
            proposals.Add(model);
            return model;
        }

        public ProposalModel Approve(int proposalId)
        {
            var proposal = proposals.First(p => p.Id == proposalId);
            proposal.Approved = true;
            return proposal;
        }

        public ProposalModel GetById(int id)
        {
            return proposals.Single(p => p.Id == id);
        }
    }
}
