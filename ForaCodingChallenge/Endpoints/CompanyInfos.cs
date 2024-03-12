using Application.Queries.GetCompanyInfo;
using MediatR;
using WebAPI.Infrastructure;

namespace WebAPI.Endpoints
{
    public class CompanyInfos : EndpointGroupBase
    {
        public override void Map(WebApplication app)
        {
            app.MapGroup(this)
                .MapGet(GetCompanyInfosAsync);
        }

        public async Task<List<EdgarCompanyInfoDto>> GetCompanyInfosAsync(ISender sender, [AsParameters] GetCompanyInfoQuery query)
        {
            return await sender.Send(query);
        }
    }
}
