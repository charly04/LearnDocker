using LearnDocker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnDocker.Data.Repositories
{
    public interface ICandidateRepository
    {
        public Task<Candidate> Get(int id);
        public Task<List<Candidate>> GetAll();
        public Task<Candidate> Add(Candidate request);
        public Task<int> Remove(int id);
        public Task<Candidate> Update(Candidate candidate, int id);
    }
}
