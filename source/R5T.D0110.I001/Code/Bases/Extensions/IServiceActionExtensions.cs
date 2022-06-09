using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0110.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedSummaryFileNameProvider"/> implementation of <see cref="ISummaryFileNameProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISummaryFileNameProvider> AddConstructorBasedSummaryFileNameProviderAction(this IServiceAction _,
            string summaryFileName)
        {
            var serviceAction = _.New<ISummaryFileNameProvider>(services => services.AddConstructorBasedSummaryFileNameProvider(summaryFileName));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedSummaryFilePathProvider"/> implementation of <see cref="ISummaryFilePathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISummaryFilePathProvider> AddConstructorBasedSummaryFilePathProviderAction(this IServiceAction _,
            string summaryFilePath)
        {
            var serviceAction = _.New<ISummaryFilePathProvider>(services => services.AddConstructorBasedSummaryFilePathProvider(summaryFilePath));
            return serviceAction;
        }
    }
}
