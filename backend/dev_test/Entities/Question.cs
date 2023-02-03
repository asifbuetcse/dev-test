using System.ComponentModel.DataAnnotations;

namespace dev_test.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string? Text { get; set; }
        public virtual Survey Survey { get; set; }
    }
}
