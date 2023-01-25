using dev_test.DTOs;

namespace dev_test.Repositories.Contracts
{
    public interface ISurveyRepository
    {
        public IEnumerable<SurveyComposite> GetSurveys();
        public void PostSurveys(SurveyComposite survey);
    }
}
