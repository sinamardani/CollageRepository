using Collage.EfCoreContext.ConnectionSetting;
using Collage.Interface;
using Collage.Models.AddressSetting;

namespace Collage.EfCoreContext.EfRepository
{
    public class EfAddressSettingRepository : IAddressSettingRepository
    {
        private readonly DBSContext dbContext;

        public EfAddressSettingRepository(DBSContext dbContext)
        {
            this.dbContext = dbContext;
        }

        List<Province> IAddressSettingRepository.GetProvinces()
        {
            return dbContext.Provinces.Where(p => !p.IsDeleted).ToList();
        }
    }
}
