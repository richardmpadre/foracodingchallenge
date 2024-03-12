using Application.Queries.GetCompanyInfo;

namespace Application.Common.Interfaces
{
    public interface ICompanyFundingService
    {
        decimal CalculateStandardFundableAmount(EdgarCompanyInfoDto companyInfo);
        decimal CalculateSpecialFundableAmount(EdgarCompanyInfoDto companyInfo);
    }
}
