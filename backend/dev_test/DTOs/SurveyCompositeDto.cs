namespace dev_test.DTOs
{
    public class SurveyCompositeDto
    {
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<QuestionCompositeDto>? Questions { get; set; }
    }
}
