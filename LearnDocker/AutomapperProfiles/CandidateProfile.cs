using AutoMapper;
using LearnDocker.Data.Entities;
using LearnDocker.Data.Requests;

namespace LearnDocker.API.AutomapperProfiles
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
            CreateMap<PostCandidateRequest, Candidate>();
            CreateMap<UpdateCandidateRequest, Candidate>();
        }
    }
}
