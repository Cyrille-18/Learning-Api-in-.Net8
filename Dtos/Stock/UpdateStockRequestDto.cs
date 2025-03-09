using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "CompanyName cannot be over 10 characters")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(0, 1000000000, ErrorMessage = "Purchase must be between 0 and 1000000000")]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100, ErrorMessage = "LastDiv must be between 0.001 and 100")]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be over 10 characters")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1, 5000000000, ErrorMessage = "MarketCap must be between 1 and 5000000000")]
        public long MarketCap { get; set; }
    }
}