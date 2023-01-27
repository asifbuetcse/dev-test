using dev_test.DTOs;
using dev_test.Repositories.Contracts;
using dev_test.Services.Contracts;

namespace dev_test.Services
{
    public class SurveyService : ISurveyService
    {
        public ISurveyRepository _surveyRepository;
        public SurveyService(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }
        public IEnumerable<Survey> GetSurveys()
        {
            return _surveyRepository.GetSurveys();
        }

        public void PostSurveys(SurveyComposite survey)
        {
            _surveyRepository.PostSurveys(survey);
        }
    }
}
