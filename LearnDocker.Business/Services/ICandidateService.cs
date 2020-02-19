using LearnDocker.Data.Entities;
using LearnDocker.Data.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnDocker.Services.Business
{
    public interface ICandidateService
    {
        public Candidate GetMockCandidate();
        public Task<Candidate> GetCandidateByID(int id);
        public Task<List<Candidate>> GetAllCandidates();
        public Task<Candidate> PostCandidate(PostCandidateRequest request);
        public Task<int> RemoveCandidate(int id);
        public Task<Candidate> UpdateCandidate(UpdateCandidateRequest request, int id);
    }
}