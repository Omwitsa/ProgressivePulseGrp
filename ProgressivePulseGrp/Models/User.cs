namespace ProgressivePulseGrp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? UserID { get; set; }
        public string? Names { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set;}
        public string? Site { get; set;}
        public bool? Status { get; set; }
        public AccessLevel? AccessLevel { get; set; }
        public string? Personnel { get; set; } 
        public DateTime? DateCreated { get; set; }
    }

    public enum AccessLevel
    {
        General = 1,
        Site = 2,
    }
}
