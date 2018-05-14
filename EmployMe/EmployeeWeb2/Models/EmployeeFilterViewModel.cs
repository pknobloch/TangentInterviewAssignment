using EmployeeWeb2.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWeb2.Models
{
    public class EmployeeFilterViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public RaceEnum? Race { get; set; }
        public GenderEnum? Gender { get; set; }
        public PositionEnum? Position { get; set; }
        [Display(Name="Birth Date")]
        public DateRangeEnum? BirthDateRange { get; set; }
        [Display(Name="Start Date")]
        public DateRangeEnum? StartDateRange { get; set; }
        public string Email { get; set; }
        [Display(Name="User")]
        public int? UserId { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; }
    }
}