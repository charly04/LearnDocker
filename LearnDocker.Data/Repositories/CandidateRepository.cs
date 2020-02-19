using LearnDocker.Data.Entities;
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

        public async Task<Candidate> Get(string id)
        {
            return await context.Set<Candidate>().FindAsync(id);
        }


    }
}
