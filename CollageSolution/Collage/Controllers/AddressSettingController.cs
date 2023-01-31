using Collage.EfCoreContext.ConnectionSetting;
using Collage.Models.AddressSetting;
using Collage.ViewModels;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Collage.Controllers
{
    public class AddressSettingController : Controller
    {
        private readonly DBSContext dbContext;

        public AddressSettingController(DBSContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult AddressSettingView()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ProvinceInsert([FromBody] ProvinceViewModel model)
        {
            var insert = new Province
            {
                CreateDate = DateTime.Now,
                CreateUser = 1,
                IsActivated = true,
                ProvinceName = model.ProvinceName,
            };
            dbContext.Set<Province>().Add(insert);
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public object GetProvince(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(dbContext.Provinces.Where(p => !p.IsDeleted).ToList(), loadOptions);
        }

        [HttpPost]
        public IActionResult CityInsert([FromBody] CityViewModel model)
        {
            var insert = new City
            {
                CityName= model.CityName,
                CreateDate= DateTime.Now,
                CreateUser= 1,
                IsActivated = true,
                ProvinceId=model.ProvinceId
            };
            dbContext.Set<City>().Add(insert);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
