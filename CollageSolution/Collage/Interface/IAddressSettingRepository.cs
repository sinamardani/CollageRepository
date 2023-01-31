using Collage.Models.AddressSetting;

namespace Collage.Interface
{
    public interface IAddressSettingRepository
    {
        List<Province> GetProvinces();
    }
}
