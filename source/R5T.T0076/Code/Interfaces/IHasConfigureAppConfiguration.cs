using System;

using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Hosting;


namespace R5T.T0076
{
    /// <remarks>
    /// Has the same name as R5T.E0040.T014.IHasConfigureAppConfiguration, but this uses the <see cref="WebHostBuilderContext"/> type, not HostBuilderContext.
    /// </remarks>
    public interface IHasConfigureAppConfiguration<TAppConfigurationBuilder>
        where TAppConfigurationBuilder : IHasConfigureAppConfiguration<TAppConfigurationBuilder>
    {
        TAppConfigurationBuilder ConfigureAppConfiguration(Action<WebHostBuilderContext, IConfigurationBuilder> configureAction);
    }
}
