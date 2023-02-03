using dev_test.DTOs;

namespace dev_test.Repositories.Contracts
{
    public interface ISurveyRepository
    {
        public IEnumerable<Entities.Survey> GetSurveys();
        public void PostSurveys(SurveyCompositeDto survey);
    }
}
