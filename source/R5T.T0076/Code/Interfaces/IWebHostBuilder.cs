using System;

using Microsoft.AspNetCore.Hosting;

using R5T.T0073;
using R5T.T0074;


namespace R5T.T0076
{
    public interface IWebHostBuilder : 
        IHasConfigureAppConfiguration<IWebHostBuilder>,
        IHasConfigureConfiguration<IWebHostBuilder>,
        IHasConfigureServices<IWebHostBuilder>,
        T0072.IHasConfigureServices<IWebHostBuilder>,
        IHasConfigureApplication<IWebHostBuilder>,
        IHasConfigureWebHost<IWebHostBuilder>
    {
        IWebHost Build();
    }
}
