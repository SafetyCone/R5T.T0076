using System;
using System.Collections.Generic;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using IMicrosoftWebHostBuilder = Microsoft.AspNetCore.Hosting.IWebHostBuilder;
using MicrosoftWebHostBuilder = Microsoft.AspNetCore.Hosting.WebHostBuilder;


namespace R5T.T0076
{
    public class WebHostBuilder : IWebHostBuilder
    {
        private MicrosoftWebHostBuilder MicrosoftWebHostBuilder { get; }
        private List<Action<IMicrosoftWebHostBuilder>> WebHostBuilderConfigureActions { get; } = new List<Action<IMicrosoftWebHostBuilder>>();


        public WebHostBuilder()
        {
            this.MicrosoftWebHostBuilder = new MicrosoftWebHostBuilder();
        }

        public WebHostBuilder(MicrosoftWebHostBuilder microsoftWebHostBuilder)
        {
            this.MicrosoftWebHostBuilder = microsoftWebHostBuilder;
        }

        public IWebHost Build()
        {
            foreach (var webHostBuilderConfigureAction in this.WebHostBuilderConfigureActions)
            {
                webHostBuilderConfigureAction(this.MicrosoftWebHostBuilder);
            }

            var output = this.MicrosoftWebHostBuilder.Build();
            return output;
        }

        public IWebHostBuilder ConfigureAppConfiguration(Action<WebHostBuilderContext, IConfigurationBuilder> configureAction)
        {
            this.MicrosoftWebHostBuilder.ConfigureAppConfiguration(configureAction);

            return this;
        }

        public IWebHostBuilder ConfigureApplication(Action<IApplicationBuilder> configureAction)
        {
            this.MicrosoftWebHostBuilder.Configure(configureAction);

            return this;
        }

        public IWebHostBuilder ConfigureConfiguration(Action<IConfigurationBuilder> configureAction)
        {
            this.MicrosoftWebHostBuilder.ConfigureAppConfiguration(configureAction);

            return this;
        }

        public IWebHostBuilder ConfigureWebHost(Action<IMicrosoftWebHostBuilder> configureAction)
        {
            this.WebHostBuilderConfigureActions.Add(configureAction);

            return this;
        }

        public IWebHostBuilder ConfigureServices(Action<WebHostBuilderContext, IServiceCollection> configureAction)
        {
            this.MicrosoftWebHostBuilder.ConfigureServices(configureAction);

            return this;
        }

        public IWebHostBuilder ConfigureServices(Action<IServiceCollection> configureAction)
        {
            this.MicrosoftWebHostBuilder.ConfigureServices(configureAction);

            return this;
        }
    }
}
