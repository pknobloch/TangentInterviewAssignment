using EmployeeWeb2.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.Models
{
    public class EmployeeFilterViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public RaceEnum? Race { get; set; }
        public GenderEnum? Gender { get; set; }
        public string Email { get; set; }
    }
}