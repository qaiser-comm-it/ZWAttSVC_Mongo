using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ZW.AttSvc.Mongo.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
