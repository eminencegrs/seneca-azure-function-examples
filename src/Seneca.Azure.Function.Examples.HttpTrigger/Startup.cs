﻿using System;
using System.Net.Http;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Seneca.Azure.Function.Examples.HttpTrigger;

[assembly: FunctionsStartup(typeof(Startup))]

namespace Seneca.Azure.Function.Examples.HttpTrigger
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();

            builder.Services.Configure<AppSettings>(configuration);

            builder.Services.AddLogging();
        }
    }
}
