using System.ComponentModel.DataAnnotations;

namespace dev_test.Entities
{
    public class SubmissionDetail
    {
        [Key]
        public int Id { get; set; }
        public int SubmissionId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public virtual Submission Submission { get; set; }
        
    }
}
