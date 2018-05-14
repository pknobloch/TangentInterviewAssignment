using EmployeeWeb2.BusinessLogic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeWeb2.Models
{
    public class ReviewViewModel
    {
        public int id { get; set; }
        [Display(Name = "Date")]
        public string date { get; set; }
        [Display(Name = "Salary")]
        public double salary { get; set; }
        public string type { get; set; }
        [Display(Name = "Type")]
        public string type_display { get { return type.KeyToEmployeeReviewType(); } set { type = value.EmployeeReviewTypeToKey(); } }
        public int employee { get; set; }
        public int position { get; set; }
    }
}