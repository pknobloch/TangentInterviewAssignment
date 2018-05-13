using AutoMapper;
using EmployeeWeb2.Models;
using EmployeeWeb2.Models.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<TangentEmployee, ProfileViewModel>();
                cfg.CreateMap<TangentUser, UserViewModel>();
                cfg.CreateMap<TangentPosition, PositionViewModel>();
                
            });
        }

    }
}