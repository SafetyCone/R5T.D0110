using System;

using R5T.D0048;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0110.I002
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SummaryFilePathProvider"/> implementation of <see cref="ISummaryFilePathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISummaryFilePathProvider> AddSummaryFilePathProviderAction(this IServiceAction _,
            IServiceAction<IOutputFilePathProvider> outputFilePathProviderAction,
            IServiceAction<ISummaryFileNameProvider> summaryFileNameProviderAction)
        {
            var serviceAction = _.New<ISummaryFilePathProvider>(services => services.AddSummaryFilePathProvider(
                outputFilePathProviderAction,
                summaryFileNameProviderAction));

            return serviceAction;
        }
    }
}
