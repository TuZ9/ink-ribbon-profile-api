﻿using Hangfire.Dashboard;
using System.Diagnostics.CodeAnalysis;

namespace ink_ribbon_profile_api.Infra.Ioc.Hangfire
{
    public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize([NotNull] DashboardContext context)
        {
            throw new NotImplementedException();
        }
    }
}
