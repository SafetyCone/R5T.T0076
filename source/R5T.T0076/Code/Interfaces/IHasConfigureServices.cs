using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Hosting;


namespace R5T.T0076
{
    /// <remarks>
    /// Same name as <see cref="T011.IHasConfigureServices{TServicesBuilder}"/>, but this includes the <see cref="WebHostBuilderContext"/>.
    /// </remarks>
    public interface IHasConfigureServices<TServicesBuilder>
        where TServicesBuilder : IHasConfigureServices<TServicesBuilder>
    {
        TServicesBuilder ConfigureServices(Action<WebHostBuilderContext, IServiceCollection> configureAction);
    }
}
