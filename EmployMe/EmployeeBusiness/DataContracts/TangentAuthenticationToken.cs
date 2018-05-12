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
        private string token;
        public override string ToString()
        {
            return token;
        }
    }
}
