using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.BusinessLogic
{
    public enum PositionEnum
    {
        [Display(Name = "Back-end Developer - Junior")]
        Back_end_Developer_Junior = 2,
        [Display(Name = "Front-end Developer - Senior")]
        Front_end_Developer_Senior = 1,
        [Display(Name = "Project Manager - Senior")]
        Project_Manager_Senior = 3,
        [Display(Name = "Project Manager - Junior")]
        Project_Manager_Junior = 4
    }
}