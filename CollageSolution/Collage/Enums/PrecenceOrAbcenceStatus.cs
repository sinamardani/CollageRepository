using System.ComponentModel.DataAnnotations;

namespace Collage.Enums
{
    public enum PrecenceOrAbcenceStatus
    {
        [Display(Name = "غایب")]
        Precence = 0,
        [Display(Name = "حاضر")]
        Abcence = 1,
    }
}
