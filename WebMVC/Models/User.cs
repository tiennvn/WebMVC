namespace WebMVC.Models
{
    public class User
    {
        public string? RequestId { get; set; }
        public string? UserId { get; set; }
        public string UserName { get; set; }
        public int UserCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
