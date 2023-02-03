namespace dev_test.DTOs
{
    public class QuestionCompositeDto
    {
        public int SurveyId { get; set; }
        public string? Text { get; set; }
        public List<AnswerDto>? Answers { get; set; }
    }
}
