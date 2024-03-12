using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Application.Queries.GetCompanyInfo
{
    public record GetCompanyInfoQuery : IRequest<List<EdgarCompanyInfoDto>>
    {
        public char? StartsWith { get; set; }
    }

    public class GetCompanyInfoQueryHandler : IRequestHandler<GetCompanyInfoQuery, List<EdgarCompanyInfoDto>>
    {
        private readonly IApplicationDbContext _appDbContext;
        private readonly HttpClient _httpClient;

        public GetCompanyInfoQueryHandler(IApplicationDbContext appDbContext, HttpClient httpClient)
        {
            _appDbContext = appDbContext;
            _httpClient = httpClient;
        }

        public async Task<List<CompanyFundingDto>> Handle(GetCompanyInfoQuery request, CancellationToken cancellationToken)
        {
            var supportedCompanies = await _appDbContext.CompanyInfos
                .Take(5)
                .ToListAsync();
            var result = new List<CompanyFundingDto>();

            foreach (var supportedCompany in supportedCompanies)
            {
                try
                {
                    var cidKey = supportedCompany.Cik.ToString().PadLeft(10, '0');
                    var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"https://data.sec.gov/api/xbrl/companyfacts/CIK{cidKey}.json");
                    httpRequest.Headers.Add("User-Agent", "PostmanRuntime/7.34.0");
                    httpRequest.Headers.Add("Accept", "*/*");

                    var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var companyInfo = JsonConvert.DeserializeObject<EdgarCompanyInfoDto>(json);
                    if (companyInfo == null ) { }

                    CompanyFundingDto companyFundingDto = null;

                    // Business logic to get companyFundingDto by passing companyInfo

                    result.Add(companyFundingDto);
                }
                catch (Exception ex)
                {
                    // Log exception
                }
                
            }

            return result;
        }

        
    }
}
