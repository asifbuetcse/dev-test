namespace dev_test.DTOs
{
    public class Submission
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int UserId { get; set; }
        public int Answer1 { get; set; }
        public int Answer2 { get; set; }
        public int Answer3 { get; set; }
        public int Score { get; set; }
    }
}
