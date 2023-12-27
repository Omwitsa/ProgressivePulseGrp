using ProgressivePulseGrp.ViewModel;

namespace ProgressivePulseGrp.Constants
{
    public class ArrValues
    {
        //public static string[] DayTimes = new string[] { "AM", "PM" };
        public static PrivilegeVm[] Privileges = new PrivilegeVm[] {
            new PrivilegeVm {
                Code = "01",
                Name = "Admin",
                ParentCode = ""
            },
            new PrivilegeVm {
                Code = "02",
                Name = "Finance",
                ParentCode = ""
            },
        };
    }
}
