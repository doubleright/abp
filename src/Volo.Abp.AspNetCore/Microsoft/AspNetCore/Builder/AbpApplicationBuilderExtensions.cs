﻿using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Volo;
using Volo.Abp;
using Volo.DependencyInjection;

namespace Microsoft.AspNetCore.Builder
{
    public static class AbpApplicationBuilderExtensions
    {
        public static void InitializeApplication([NotNull] this IApplicationBuilder app)
        {
            Check.NotNull(app, nameof(app));

            app.ApplicationServices.GetRequiredService<ObjectAccessor<IApplicationBuilder>>().Object = app;
            app.ApplicationServices.GetRequiredService<AbpApplication>().Initialize(app.ApplicationServices);
        }
    }
}
