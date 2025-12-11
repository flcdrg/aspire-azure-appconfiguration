#:package Aspire.Hosting.Azure.AppConfiguration@13.0.2
#:sdk Aspire.AppHost.Sdk@13.0.2

var builder = DistributedApplication.CreateBuilder(args);

var appconfig = builder.AddConnectionString("appconfig");

builder.AddExecutable("pwsh", "pwsh", "", "-NoLogo", "-NoProfile", "-Command", "Get-ChildItem Env:")
    .WithReference(appconfig);

builder.Build().Run();
