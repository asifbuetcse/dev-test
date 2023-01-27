namespace dev_test.DTOs
{
    public class SurveyComposite
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<QuestionComposite> Questions { get; set; }
    }
}
