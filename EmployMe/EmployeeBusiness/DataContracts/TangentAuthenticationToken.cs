using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusiness.DataContracts
{
    public class TangentAuthenticationToken
    {
        public TangentAuthenticationToken(string token)
        {
            this.token = token;
        }
        public string token { get; private set; }
    }
}
