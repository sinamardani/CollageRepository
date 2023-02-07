using Collage.BaseModels;
using Collage.Models.PrecenceAbcence;

namespace Collage.Models
{
    public class PrecenceAbcenceS : BaseTableOptions
    {
        public Enums.PrecenceOrAbcenceStatus PrecenceOrAbcenceStatus { get; set; }
        public int StudentId { get; set; }
        public virtual Student Students { get;set; }
    }
}
