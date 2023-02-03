using System.ComponentModel.DataAnnotations;

namespace dev_test.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public bool IsActive { get; set; }
        public string? Role { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
    }

}
