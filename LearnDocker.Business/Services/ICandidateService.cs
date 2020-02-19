using LearnDocker.Data.Entities;
using System.Threading.Tasks;

namespace LearnDocker.Services.Business
{
    public interface ICandidateService
    {
        public Candidate GetMockCandidate();
        public Task<Candidate> GetCandidateByID(string id);
    }
}