using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Collage.Enums
{
    public enum ContactUsStatus
    {
        [Display(Name = "ارسال شده")]
        Send = 0,
        [Display(Name = "خوانده شده")]
        Read = 1,
        [Display(Name = "خوانده نشده")]
        UnRead = 2
    }
}
