using LearnDocker.Data;

namespace LearnDocker.Business
{
    public class CandidateService : ICandidateService
    {
        public Candidate MockCandidate()
        {
            return new Candidate();
        }
    }
}
