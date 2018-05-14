using EmployeeWeb2.Models;
using EmployeeWeb2.Models.DataContracts;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EmployeeWeb2.BusinessLogic;

namespace EmployeeBusiness
{
    /// <summary>
    /// This provides functionality to interact with the Tangent Employee Services
    /// </summary>
    public class TangentEmployeeService
    {
        private readonly string baseUrl;
        public TangentAuthenticationToken Token { get; private set; }
        public bool IsAuthenticated => Token != null;

        //Event used in unit tests because async is not supported
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
        private async Task<TangentAuthenticationToken> LoginAsync(string url, TangentLoginDetails details)
        {
            var jsonDetails = JsonConvert.SerializeObject(details);
            return await Post<TangentAuthenticationToken>(url, jsonDetails);
        }
        private async Task<T> Get<T>(string url)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Token {Token}");
            var content = await httpClient.GetAsync(url);
            var response = await content.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(response);
        }
        private async Task<T> Post<T>(string url, string jsonDetails)
        {
            var content = await new HttpClient().PostAsync(url, BuildStringContent(jsonDetails));
            var response = await content.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(response);
        }
        private static HttpContent BuildStringContent(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
        public async Task<List<TangentEmployee>> FetchEmployeesAsync()
        {
            var url = $"{baseUrl}api/employee/";
            return await Get<List<TangentEmployee>>(url);
        }
        public async Task<List<TangentEmployee>> SearchEmployeesAsync(EmployeeFilterViewModel model)
        {
            var filters = new List<string>();
            if (model.Race != null)
            {
                filters.Add($"race={model.Race.ToString().RaceToKey()}");
            }
            if (model.Gender != null)
            {
                filters.Add($"gender={model.Gender.ToString().GenderToKey()}");
            }
            if (model.Position != null)
            {
                filters.Add($"position={model.Position.Value}");
            }
            if (model.BirthDateRange != null)
            {
                filters.Add($"birth_date_range={model.BirthDateRange.Value}");
            }
            if (model.BirthDateRange != null)
            {
                filters.Add($"start_date_range={model.StartDateRange.Value}");
            }
            if (!string.IsNullOrEmpty(model.Email))
            {
                filters.Add($"email__contains={model.Email}");
            }
            if (model.UserId.HasValue)
            {
                filters.Add($"user={model.UserId}");
            }
            var url = $"{baseUrl}api/employee/";
            if (filters.Any()) { url += $"?{string.Join("&", filters)}"; };
            return await Get<List<TangentEmployee>>(url);
        }
        public async Task<TangentEmployee> FetchEmployeeAsync(int userId)
        {
            var url = $"{baseUrl}api/employee/{userId}/";
            return await Get<TangentEmployee>(url);
        }
        public async Task<TangentEmployee> FetchMyEmployeeProfileAsync()
        {
            var url = $"{baseUrl}api/employee/me/";
            return await Get<TangentEmployee>(url);
        }
        public async Task<TangentUser> FetchMyUserAsync()
        {
            var url = $"{baseUrl}api/user/me/";
            return await Get<TangentUser>(url);
        }
        public async Task<List<TangentReview>> FetchReviewsAsync()
        {
            var url = $"{baseUrl}api/review/";
            return await Get<List<TangentReview>>(url);
        }
        public async Task<List<TangentLeave>> FetchLeaveAsync()
        {
            var url = $"{baseUrl}api/leave/";
            return await Get<List<TangentLeave>>(url);
        }
        public async Task<List<TangentLeave>> FetchLeaveAsync(int employeeId)
        {
            var url = $"{baseUrl}api/leave/?employee={employeeId}";
            return await Get<List<TangentLeave>>(url);
        }
    }
}
