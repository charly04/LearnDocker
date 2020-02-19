using System;
using LearnDocker.Services.Business;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearnDocker.API.Controllers
{
    [Route("api/candidate")]
    public class CandidateController : Controller
    {
        private readonly ICandidateService candidateService;

        public CandidateController( ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }

        /// <summary>
        /// Get mocked candidate by ID
        /// </summary>
        /// <param name="id">Database identification number</param>
        /// <returns></returns>
        [HttpGet("mock/{id}", Name = "MockedCandidateByID")]
        public async Task<IActionResult> GetMockedCandidateByID(int id)
        {
            return Ok(candidateService.GetMockCandidate());
        }

        /// <summary>
        /// Get candidate by ID
        /// </summary>
        /// <param name="id">Database identification number</param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "CandidateByID")]
        public async Task<IActionResult> GetCandidateByID(string id)
        {
            try
            {
                var candidate = await candidateService.GetCandidateByID(id);
                if (candidate != null)
                {
                    return Ok(candidate);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception("Internal error");
            }
        }
    }
}
