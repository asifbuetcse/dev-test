using AutoMapper;
using dev_test.DTOs;
using dev_test.Entities;

namespace dev_test
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<Survey, SurveyDto>().ReverseMap();
        }
    }
}
