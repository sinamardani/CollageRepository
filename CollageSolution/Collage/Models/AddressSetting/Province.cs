using Collage.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collage.Models.AddressSetting
{
    public class Province : BaseTableOptions
    {
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? ProvinceName { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
