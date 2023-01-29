using System.ComponentModel.DataAnnotations;

namespace Collage.BaseModels
{
    public class BaseIdentity<T>
    {
        [Key]
        public T? ID { get; set; }
    }
}
