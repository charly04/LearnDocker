using LearnDocker.Data;
using LearnDocker.Business;
using Microsoft.AspNetCore.Mvc;

namespace LearnDocker.API
{
    [Route("api/candidate")]
    public class CandidateController : Controller
    {
        private readonly ICandidateService candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }

        /// <summary>
        /// Get basic candidate 
        /// </summary>
        /// <param name="id">Database identification number</param>
        /// <returns></returns>
        [HttpGet("{identificationNumber}")]
        public Candidate GetCandidateBasicInformation(int identificationNumber)
        {
            return candidateService.MockCandidate();
        }
    }
}
