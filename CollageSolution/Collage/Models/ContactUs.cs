using Collage.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collage.Models
{
    public class ContactUs : BaseTableOptions
    {
        public Enums.ContactUsStatus ContactUsStatus { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(15)")]
        public string? Name { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? Email { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(25)")]
        public string? Subject { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(128)")]
        public string? Message { get; set; }
    }
}
