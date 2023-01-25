using dev_test.DTOs;

namespace dev_test.Services.Contracts
{
    public interface ISurveyService
    {
        public IEnumerable<SurveyComposite> GetSurveys();
        public void PostSurveys(SurveyComposite survey);
    }
}
