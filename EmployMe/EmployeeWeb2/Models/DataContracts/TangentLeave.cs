using EmployeeWeb2.Models.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.Models.DataContracts
{
    public class TangentLeave
    {
        public string id { get; set; }
        public TangentEmployee employee { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string status { get; set; }
        public string half_day { get; set; }
        public string type { get; set; }
        public string upload { get; set; }
        public string leave_days { get; set; }
    }
}