namespace dev_test.DTOs
{
    public class QuestionComposite
    {
        public int SurveyId { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
