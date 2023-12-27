namespace ProgressivePulseGrp.Models
{
    public class UserPrivilege
    {
        public int Id { get; set; }
        public int? UserGroupId { get; set; }
        public string? PrivilegeCode { get; set; }
    }
}