using Collage.BaseModels;
using Collage.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collage.Models
{
    public class Stu : BaseTableOptions
    {
        [Column(TypeName = "NVARCHAR(50)")]
        public string? FirstName { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string? LastName { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string? Email { get; set; }
        [Column(TypeName = "VARCHAR(13)")]
        public string? PhoneNuber { get; set; }
        public ICollection<PrecenceAbcenceS> PrecenceAbcence { get; set; }
    }
}
