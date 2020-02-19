using System;
using LearnDocker.Services.Business;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using LearnDocker.Data.Requests;
using AutoMapper;

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
        public async Task<IActionResult> GetCandidateByID(int id)
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

        /// <summary>
        /// Get all candidates
        /// </summary>
        /// <returns></returns>
        [HttpGet("all", Name = "AllCandidates")]
        public async Task<IActionResult> GetAllCandidates()
        {
            try
            {
                var candidates = await candidateService.GetAllCandidates();
                if (candidates.Any())
                {
                    return Ok(candidates);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception("Internal error");
            }
        }

        /// <summary>
        /// Post candidate
        /// </summary>
        /// <returns></returns>
        [HttpPost("new", Name = "PostCandidate")]
        public async Task<IActionResult> PostCandidate(PostCandidateRequest request)
        {
            try
            {
                var response = await candidateService.PostCandidate(request);
                if (response != null)
                {
                    return Ok(response);
                }

                return StatusCode(500, "Unexpected error");
            }
            catch (Exception ex)
            {
                throw new Exception("Internal error");
            }
        }

        /// <summary>
        /// Remove candidate
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}", Name = "RemoveCandidate")]
        public async Task<IActionResult> RemoveCandidate(int id)
        {
            try
            {
                var response = await candidateService.RemoveCandidate(id);
                if (response != null)
                {
                    return Ok($"Successfully removed user with Id: {response}");
                }

                return StatusCode(500, "Unexpected error");
            }
            catch (Exception ex)
            {
                throw new Exception("Internal error");
            }
        }

        /// <summary>
        /// Update candidate
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}", Name = "UpdateCandidate")]
        public async Task<IActionResult> UpdateCandidate(UpdateCandidateRequest request, int id)
        {
            try
            {
                var response = await candidateService.UpdateCandidate(request, id);
                if (response != null)
                {
                    return Ok(response);
                }

                return StatusCode(500, "Unexpected error");
            }
            catch (Exception ex)
            {
                throw new Exception("Internal error");
            }
        }
    }
}
