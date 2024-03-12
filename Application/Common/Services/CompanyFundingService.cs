using Application.Common.Interfaces;
using Application.Queries.GetCompanyInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Services
{
    public class CompanyFundingService : ICompanyFundingService
    {
        public decimal CalculateSpecialFundableAmount(EdgarCompanyInfoDto companyInfo)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateStandardFundableAmount(EdgarCompanyInfoDto companyInfo)
        {
            const decimal Billion = 1000000000;
            var requiredYears = new[] { "CY2018", "CY2019", "CY2020", "CY2021", "CY2022" };
            var incomeData = new Dictionary<string, decimal>();

            foreach (var income in companyInfo.Facts.UsGaap.NetIncomeLoss.Units.Usd)
            {
                if (income.Form == "10-K" && requiredYears.Contains(income.Frame))
                {
                    incomeData[income.Frame] = income.Val;
                }

                if (requiredYears.Any(year => !incomeData.ContainsKey(year)))
                {
                    return 0;
                }

                if (incomeData["CY2021"] <= 0 || incomeData["CY2022"] <= 0)
                {
                    return 0;
                }
            }

            throw new NotImplementedException();
        }

        private List<NetIncomeData> ExtractYearlyNetIncome(EdgarCompanyInfoDto companyInfo)
        {
            var netIncomeDataList = new List<NetIncomeData>();

            if (companyInfo?.Facts?.UsGaap?.NetIncomeLoss?.Units?.Usd != null)
            {
                foreach (var incomeData in companyInfo.Facts.UsGaap.NetIncomeLoss.Units.Usd)
                {
                    if (incomeData.Form == "10-K" && incomeData.Frame.StartsWith("CY"))
                    {
                        netIncomeDataList.Add(new NetIncomeData
                        {
                            Year = incomeData.Frame,
                            NetIncome = incomeData.Val
                        });
                    }
                }
            }

            return netIncomeDataList;
        }
    }
}
