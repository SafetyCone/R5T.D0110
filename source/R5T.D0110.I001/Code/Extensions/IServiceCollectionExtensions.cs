using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0110.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedSummaryFileNameProvider"/> implementation of <see cref="ISummaryFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedSummaryFileNameProvider(this IServiceCollection services,
            string summaryFileName)
        {
            services.AddSingleton<ISummaryFileNameProvider>(_ => new ConstructorBasedSummaryFileNameProvider(summaryFileName));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedSummaryFilePathProvider"/> implementation of <see cref="ISummaryFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedSummaryFilePathProvider(this IServiceCollection services,
            string summaryFilePath)
        {
            services.AddSingleton<ISummaryFilePathProvider>(_ => new ConstructorBasedSummaryFilePathProvider(summaryFilePath));

            return services;
        }
    }
}