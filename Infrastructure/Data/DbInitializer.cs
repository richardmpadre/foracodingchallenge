using Domain.Entities;

namespace Infrastructure.Data
{
    public class DbInitializer
    {
        public static void Initialize(InMemoryAppDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            context.CompanyInfos.Add(new CompanyInfo { Cik = 18926 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 892553 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1510524 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1858912 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1828248 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1819493 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 60086 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1853630 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1761312 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1851182 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1034665 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 927628 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1125259 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1547660 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1393311 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1757143 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1958217 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 312070 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 310522 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1861841 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1037868 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1696355 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1166834 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 915912 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1085277 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 831259 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 882291 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1521036 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1824502 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1015647 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 884624 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1501103 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1397183 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1552797 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1894630 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 823277 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 21175 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1439124 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 52827 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1730773 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1867287 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1685428 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1007587 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 92103 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1641751 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 6845 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1231457 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 947263 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 895421 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1988979 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1848898 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 844790 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1541309 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1858007 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1729944 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 726958 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1691221 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 730272 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1308106 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 884144 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1108134 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1849058 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1435617 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1857518 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 64803 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1912498 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1447380 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1232384 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1141788 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1549922 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 914475 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1498382 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1400897 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 314808 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1323885 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1526520 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1550695 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1634293 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1756708 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1540159 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1076691 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1980088 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1532346 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 923796 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1849635 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1872292 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1227857 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1046311 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1710350 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1476150 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1844642 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1967078 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 14272 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 933267 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1157557 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1560293 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 217410 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1798562 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1038074 });
            context.CompanyInfos.Add(new CompanyInfo { Cik = 1843370 });

            context.SaveChanges();
        }
    }
}
