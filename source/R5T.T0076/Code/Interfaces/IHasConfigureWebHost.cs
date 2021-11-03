using System;

using IMicrosoftWebHostBuilder = Microsoft.AspNetCore.Hosting.IWebHostBuilder;


namespace R5T.T0076
{
    public interface IHasConfigureWebHost<THostBuilder>
        where THostBuilder : IHasConfigureWebHost<THostBuilder>
    {
        THostBuilder ConfigureWebHost(Action<IMicrosoftWebHostBuilder> configureAction);
    }
}
