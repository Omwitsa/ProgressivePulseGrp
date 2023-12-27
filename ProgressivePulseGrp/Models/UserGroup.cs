namespace ProgressivePulseGrp.Models
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<UserPrivilege>? UserPrivileges { get; set; }
        public bool? Closed { get; set; }
        public string? Personnel { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}