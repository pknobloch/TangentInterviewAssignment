using System.ComponentModel.DataAnnotations;

namespace EmployeeWeb2.Models
{
    public class PositionViewModel
    {
        public int id { get; set; }
        [Display(Name = "Position")]
        public string name { get; set; }
        [Display(Name = "Level")]
        public string level { get; set; }
        [Display(Name = "Sort")]
        public int sort { get; set; }
    }
}