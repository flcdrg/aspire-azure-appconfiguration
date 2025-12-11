#:package Aspire.Hosting.Azure.AppConfiguration@13.0.2
#:sdk Aspire.AppHost.Sdk@13.0.2

var builder = DistributedApplication.CreateBuilder(args);

var configName = builder.AddParameter("configName", "appcs-appconfig-test-australiaeast");
var configResourceGroupName = builder.AddParameter("configResourceGroupName", "rg-appconfig-test-australiaeast");
var appConfig = builder.AddAzureAppConfiguration("app-config")
   .AsExisting(configName, configResourceGroupName);

builder.Build().Run();
