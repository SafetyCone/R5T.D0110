using System;
using System.Threading.Tasks;

using R5T.D0048;
using R5T.T0064;


namespace R5T.D0110.I002
{
    [ServiceImplementationMarker]
    public class SummaryFilePathProvider : ISummaryFilePathProvider, IServiceImplementation
    {
        private IOutputFilePathProvider OutputFilePathProvider { get; }
        private ISummaryFileNameProvider SummaryFileNameProvider { get; }


        public SummaryFilePathProvider(
            IOutputFilePathProvider outputFilePathProvider,
            ISummaryFileNameProvider summaryFileNameProvider)
        {
            this.OutputFilePathProvider = outputFilePathProvider;
            this.SummaryFileNameProvider = summaryFileNameProvider;
        }

        public async Task<string> GetSummaryFilePath()
        {
            var summaryFileName = await this.SummaryFileNameProvider.GetSummaryFileName();

            var output = await this.OutputFilePathProvider.GetOutputFilePath(summaryFileName);
            return output;
        }
    }
}