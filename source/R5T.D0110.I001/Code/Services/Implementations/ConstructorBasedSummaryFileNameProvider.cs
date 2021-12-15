using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0110.I001
{
    [ServiceImplementationMarker]
    public class ConstructorBasedSummaryFileNameProvider : ISummaryFileNameProvider, IServiceImplementation
    {
        private string SummaryFileName { get; }


        public ConstructorBasedSummaryFileNameProvider(
            string summaryFileName)
        {
            this.SummaryFileName = summaryFileName;
        }

        public Task<string> GetSummaryFileName()
        {
            return Task.FromResult(this.SummaryFileName);
        }
    }
}