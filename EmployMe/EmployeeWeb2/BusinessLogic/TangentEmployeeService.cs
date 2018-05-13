﻿using EmployeeBusiness.DataContracts;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusiness
{
    /// <summary>
    /// This provides functionality to interact with the Tangent Employee Services
    /// </summary>
    public class TangentEmployeeService
    {
        private string baseUrl;
        public TangentAuthenticationToken Token { get; private set; }
        public bool IsAuthenticated => Token != null;

        public event AuthenticationHandler AuthenticationFinished;
        public EventArgs e = null;
        public delegate void AuthenticationHandler(object s, EventArgs e);
        /// <summary>
        /// Constructor
        /// </summary>
        public TangentEmployeeService(string baseUrl)
        {
            if (string.IsNullOrEmpty(baseUrl))
            {
                throw new ArgumentNullException("baseUrl");
            }
            this.baseUrl = baseUrl;
        }
        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            var url = $"{baseUrl}api-token-auth/";
            var details = new TangentLoginDetails { username = username, password = password };
            Token = await LoginAsync(url, details);
            AuthenticationFinished?.Invoke(this, e);
            return IsAuthenticated;
        }
        private static async Task<TangentAuthenticationToken> LoginAsync(string url, TangentLoginDetails details)
        {
            var jsonDetails = JsonConvert.SerializeObject(details);
            var content = await new HttpClient().PostAsync(url, BuildStringContent(jsonDetails));
            var response = await content.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TangentAuthenticationToken>(response);
        }
        private static HttpContent BuildStringContent(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}