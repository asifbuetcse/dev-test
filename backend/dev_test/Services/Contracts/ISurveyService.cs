using dev_test.DTOs;

namespace dev_test.Services.Contracts
{
    public interface ISurveyService
    {
        public IEnumerable<Survey> GetSurveys();
        public void PostSurveys(SurveyComposite survey);
    }
}
