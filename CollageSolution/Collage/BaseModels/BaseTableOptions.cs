namespace Collage.BaseModels
{
    public class BaseTableOptions : BaseIdentity<int>
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool IsActivated { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
