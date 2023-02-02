using dev_test.DTOs;

namespace dev_test.Services.Contracts
{
    public interface ISurveyService
    {
        public IEnumerable<SurveyDto> GetSurveys();
        public void PostSurveys(SurveyCompositeDto survey);
    }
}
