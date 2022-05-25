using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models.Entities
{
    [Table("Products")]
    public class User
    {
        [Key]
        public string? UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string? UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
