using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.Models.DataContracts
{
    public class TangentReview
    {
        public int id { get; set; }
        public string date { get; set; }
        public double salary { get; set; }
        public string type { get; set; }
        public int employee { get; set; }
        public int position { get; set; }
    }
}