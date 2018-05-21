﻿using System.Threading.Tasks;
using Abp.Application.Services;
using JiraDashboard.Authorization.Accounts.Dto;

namespace JiraDashboard.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
