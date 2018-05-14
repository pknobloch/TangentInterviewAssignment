using System.ComponentModel.DataAnnotations;

namespace EmployeeWeb2.Models
{
    public class UserViewModel
    {
        public int id { get; set; }
        [Display(Name = "Username")]
        public string username { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        [Display(Name = "Last Name")]
        public string last_name { get; set; }
        [Display(Name = "Active?")]
        public bool is_active { get; set; }
        [Display(Name = "Staff?")]
        public bool is_staff { get; set; }
        [Display(Name = "Superuser?")]
        public bool is_superuser { get; set; }
    }
}