using Collage.BaseModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Collage.Models.AddressSetting
{
    public class City : BaseTableOptions
    {
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? CityName { get; set; }
        public int ProvinceId { get; set; }
        public virtual Province? Provinces { get; set; }

    }
}
