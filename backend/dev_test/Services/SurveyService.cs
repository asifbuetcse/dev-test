using AutoMapper;
using dev_test.DTOs;
using dev_test.Repositories.Contracts;
using dev_test.Services.Contracts;

namespace dev_test.Services
{
    public class SurveyService : ISurveyService
    {
        public ISurveyRepository _surveyRepository;
        private readonly IMapper _mapper;
        public SurveyService(ISurveyRepository surveyRepository, IMapper mapper)
        {
            _surveyRepository = surveyRepository;
            _mapper = mapper;
        }
        public IEnumerable<SurveyDto> GetSurveys()
        {
            var survey = _surveyRepository.GetSurveys();
            var surveyDtos = _mapper.Map<IEnumerable<SurveyDto>>(survey);
            return surveyDtos;
        }

        public void PostSurveys(SurveyCompositeDto survey)
        {
            //_surveyRepository.PostSurveys(survey);
        }
    }
}
