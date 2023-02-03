using System.ComponentModel.DataAnnotations;

namespace dev_test.Entities
{
    public class Survey
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
