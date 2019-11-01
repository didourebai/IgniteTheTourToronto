using System.Collections.Generic;
using Shared.Models;

namespace WebAPIs.Repositories
{
    public interface IProposalRepo
    {
        ProposalModel Add(ProposalModel model);
        ProposalModel Approve(int proposalId);
        IEnumerable<ProposalModel> GetAllForConference(int conferenceId);
        ProposalModel GetById(int id);
    }
}