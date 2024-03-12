using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class CompanyInfo
    {
        [Key]
        public int Cik { get; set; }
        public string? EntityName { get; set; }
    }
}


