﻿using MessengerX.Domain.Shared.Settings;

namespace MessengerX.WebApi.ApiConfigurations.ServiceManager;

public static partial class ServiceManagerExtension
{
    public static IServiceCollection AddConfigurationDependencies(
        this IServiceCollection serviceCollection,
        IConfiguration config
    )
    {
        Dictionary<string, IConfigurationSection> configurations =
            new()
            {
                { "commonSettings", config.GetSection(CommonSettings.Path) },
                { "authSettings", config.GetSection(AuthSettings.Path) },
                { "clientSettings", config.GetSection(ClientSettings.Path) },
                { "routePathSettings", config.GetSection(RoutePathSettings.Path) },
                { "filePathSettings", config.GetSection(FilePathSettings.Path) },
                { "smtpSettings", config.GetSection(SmtpSettings.Path) },
            };

        serviceCollection.Configure<CommonSettings>(configurations["commonSettings"]);
        serviceCollection.Configure<AuthSettings>(configurations["authSettings"]);
        serviceCollection.Configure<ClientSettings>(configurations["clientSettings"]);
        serviceCollection.Configure<RoutePathSettings>(configurations["routePathSettings"]);
        serviceCollection.Configure<FilePathSettings>(configurations["filePathSettings"]);
        serviceCollection.Configure<SmtpSettings>(configurations["smtpSettings"]);

        return serviceCollection;
    }
}
