using EmployeeBusiness;
using EmployeeWeb.Data;
using EmployeeWeb.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWeb
{
    public class TangentSigninManager<TUser> : SignInManager<TUser> where TUser : class
    {
        private readonly UserManager<TUser> _userManager;
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly AppSettings _appSettings;
        private TangentEmployeeService _tangentEmployeeService;

        public TangentSigninManager(UserManager<TUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<TUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<TUser>> logger, ApplicationDbContext dbContext, IOptions<AppSettings> appSettings)
        : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger)
    {
            if (userManager == null)
                throw new ArgumentNullException(nameof(userManager));

            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            if (contextAccessor == null)
                throw new ArgumentNullException(nameof(contextAccessor));

            _userManager = userManager;
            _contextAccessor = contextAccessor;
            _db = dbContext;
            _appSettings = appSettings.Value;
        }
        public override async Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure)
        {
            //var result = await base.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
            _tangentEmployeeService = new TangentEmployeeService(_appSettings.TangentBaseUrl);
            await _tangentEmployeeService.AuthenticateAsync(userName, password);
            if (_tangentEmployeeService.IsAuthenticated)
            {
                _contextAccessor.HttpContext.Session.SetString("TangentToken", _tangentEmployeeService.Token.ToString());
                return SignInResult.Success;
            }

            return SignInResult.Failed;
        }
        public override async Task SignOutAsync()
        {
            await base.SignOutAsync();

            _contextAccessor.HttpContext.Session.Remove("TangentToken");
            _tangentEmployeeService = null;
        }
    }
}
