using LearnDocker.Data.Entities;
using LearnDocker.Data.Repositories;
using LearnDocker.Data.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace LearnDocker.Services.Business
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository candidateRepository;
        private readonly IMapper mapper;
        public CandidateService(ICandidateRepository candidateRepository, IMapper mapper)
        {
            this.candidateRepository = candidateRepository;
            this.mapper = mapper;
        }
        public Candidate GetMockCandidate()
        {
            return new Candidate(true);
        }

        public async Task<Candidate> GetCandidateByID(int id)
        {
            return await candidateRepository.Get(id);
        }

        public async Task<List<Candidate>> GetAllCandidates()
        {
            return await candidateRepository.GetAll();
        }

        public async Task<Candidate> PostCandidate(PostCandidateRequest request)
        {
            var candidate = mapper.Map<Candidate>(request);
            return await candidateRepository.Add(candidate);
        }

        public async Task<int> RemoveCandidate(int id)
        {
            return await candidateRepository.Remove(id);
        }

        public async Task<Candidate> UpdateCandidate(UpdateCandidateRequest request, int id)
        {
            var candidate = mapper.Map<Candidate>(request);
            return await candidateRepository.Update(candidate, id);
        }
    }
}
