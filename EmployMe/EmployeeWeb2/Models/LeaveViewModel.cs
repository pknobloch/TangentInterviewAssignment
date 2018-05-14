using System.ComponentModel.DataAnnotations;

namespace EmployeeWeb2.Models
{
    public class LeaveViewModel
    {
        public int id { get; set; }
        public EmployeeViewModel employee { get; set; }
        [Display(Name = "Start Date")]
        public string start_date { get; set; }
        [Display(Name = "End Date")]
        public string end_date { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        [Display(Name = "Half Day")]
        public string half_day { get; set; }
        [Display(Name = "Type")]
        public string type { get; set; }
        [Display(Name = "Leave Day")]
        public string leave_days { get; set; }
        [Display(Name = "Upload")]
        public string upload { get; set; }
    }
}