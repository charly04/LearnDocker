using LearnDocker.Data.Entities;
using LearnDocker.Data.Requests;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnDocker.Data.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly DatabaseContext context;
        public CandidateRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<Candidate> Get(int id)
        {
            return await context.Set<Candidate>().FindAsync(id);
        }

        public async Task<List<Candidate>> GetAll()
        {
            return await context.Candidates.ToListAsync();
        }

        public async Task<Candidate> Add(Candidate candidate)
        {
            await context.Candidates.AddAsync(candidate);
            context.SaveChanges();
            return candidate;
        }

        public async Task<int> Remove(int id)
        {
            context.Candidates.Remove(context.Candidates.Find(id));
            context.SaveChanges();
            return id;
        }

        public async Task<Candidate> Update(Candidate candidate, int id)
        {
            var candidateDB = context.Candidates.Find(id);

            candidateDB.Name = candidate.Name;
            candidateDB.Surname = candidate.Surname;
            candidateDB.BirthDate = candidate.BirthDate;
            candidateDB.Address = candidate.Address;

            context.SaveChanges();

            candidate.Id = id;
            return candidate;
        }

    }
}
