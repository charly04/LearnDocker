using LearnDocker.Data.Entities;
using LearnDocker.Data.Repositories;
using System.Threading.Tasks;

namespace LearnDocker.Services.Business
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository candidateRepository;
        public CandidateService(ICandidateRepository candidateRepository)
        {
            this.candidateRepository = candidateRepository;
        }
        public Candidate GetMockCandidate()
        {
            return new Candidate(true);
        }

        public async Task<Candidate> GetCandidateByID(string id)
        {
            return await candidateRepository.Get(id);
        }
    }
}
