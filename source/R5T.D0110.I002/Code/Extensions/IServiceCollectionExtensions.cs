using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0048;
using R5T.T0063;


namespace R5T.D0110.I002
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SummaryFilePathProvider"/> implementation of <see cref="ISummaryFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSummaryFilePathProvider(this IServiceCollection services,
            IServiceAction<IOutputFilePathProvider> outputFilePathProviderAction,
            IServiceAction<ISummaryFileNameProvider> summaryFileNameProviderAction)
        {
            services
                .Run(outputFilePathProviderAction)
                .Run(summaryFileNameProviderAction)
                .AddSingleton<ISummaryFilePathProvider, SummaryFilePathProvider>();

            return services;
        }
    }
}