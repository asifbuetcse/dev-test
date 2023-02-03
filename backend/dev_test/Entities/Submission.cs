using System.ComponentModel.DataAnnotations;

namespace dev_test.Entities
{
    public class Submission
    {
        [Key]
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int UserId { get; set; }
        public virtual Survey Survey { get; set; }
        public virtual User User { get; set; }
    }
}
