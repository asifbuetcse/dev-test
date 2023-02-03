using dev_test.DTOs;
using dev_test.Entities;
using System.Transactions;

namespace dev_test.Repositories.Contracts
{
    public class SurveyRepository : ISurveyRepository
    {
        public DatabaseContext _databaseContext;
        public SurveyRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        IEnumerable<Survey> ISurveyRepository.GetSurveys()
        {
            _databaseContext.Database.EnsureCreated();
            return _databaseContext.Surveys.ToList();
        }

        void ISurveyRepository.PostSurveys(SurveyCompositeDto survey)
        {

            using (var transaction = new TransactionScope())
            {
                try
                {
                    Survey surv = new Survey
                    {
                        Title = survey.Title,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    };
                    _databaseContext.Add(surv);
                    _databaseContext.SaveChanges();
                    foreach (var ques in survey.Questions)
                    {
                        Question q = new Question
                        {
                            Text = ques.Text,
                            SurveyId = surv.Id
                        };
                        _databaseContext.Add(q);
                        _databaseContext.SaveChanges();
                        foreach (var ans in ques.Answers)
                        {
                            Answer answer = new Answer
                            {
                                QuestionId = q.Id,
                                Text = ans.Text,
                                IsCorrect = ans.IsCorrect
                            };
                            _databaseContext.Add(answer);
                            _databaseContext.SaveChanges();
                        }
                    }
                    transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Current.Rollback();
                    throw;
                }
            }
        }
    }
}
