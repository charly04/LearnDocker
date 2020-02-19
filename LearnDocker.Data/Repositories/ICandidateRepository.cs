using LearnDocker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnDocker.Data.Repositories
{
    public interface ICandidateRepository
    {
        public Task<Candidate> Get(string id);
    }
}
