using Collage.EfCoreContext.ConnectionSetting;
using Collage.Models;
using Collage.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Collage.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly DBSContext dbContext;

        public ContactUsController(DBSContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult ContactUsView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit([FromBody] ContactUsViewModel model)
        {
            var contactUs = new ContactUs()
            {
                ContactUsStatus = 0,
                CreateDate = DateTime.Now,
                CreateUser = 1,
                Email = model.Email,
                Message = model.Message,
                Subject = model.Subject,
                Name = model.Name,
            };
            dbContext.Set<ContactUs>().Add(contactUs);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
