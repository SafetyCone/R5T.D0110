using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0110
{
    [ServiceDefinitionMarker]
    public interface ISummaryFileNameProvider : IServiceDefinition
    {
        Task<string> GetSummaryFileName();
    }
}