using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0110.I001
{
    [ServiceImplementationMarker]
    public class ConstructorBasedSummaryFilePathProvider : ISummaryFilePathProvider, IServiceImplementation
    {
        private string SummaryFilePath { get; }


        public ConstructorBasedSummaryFilePathProvider(
            [NotServiceComponent] string summaryFilePath)
        {
            this.SummaryFilePath = summaryFilePath;
        }

        public Task<string> GetSummaryFilePath()
        {
            return Task.FromResult(this.SummaryFilePath);
        }
    }
}