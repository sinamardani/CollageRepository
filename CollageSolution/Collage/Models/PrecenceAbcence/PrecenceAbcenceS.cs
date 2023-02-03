using Collage.BaseModels;
using Collage.Models;

namespace Collage.Models
{
    public class PrecenceAbcenceS : BaseTableOptions
    {
        public int StudentId { get; set; }
        public Enums.PrecenceOrAbcenceStatus PrecenceOrAbcenceStatus { get; set; }
        public virtual Stu Studens { get;set; }
    }
}
