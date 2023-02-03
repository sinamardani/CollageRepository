using Collage.EfCoreContext.ConnectionSetting;
using Collage.Interface;
using Collage.Models;
using Collage.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Collage.Controllers
{
    public class PresenceAbsenceController : Controller
    {
        private readonly DBSContext dbContext;
        private readonly IPrecenceAbsecenceRepository precenceAbsecenceRepository;

        public PresenceAbsenceController(DBSContext dbContext, IPrecenceAbsecenceRepository precenceAbsecenceRepository)
        {
            this.dbContext = dbContext;
            this.precenceAbsecenceRepository = precenceAbsecenceRepository;
        }
        public IActionResult PresenceAbsenceView()
        {
            return View(precenceAbsecenceRepository.GetStudents());
        }
        [HttpPost]
        public IActionResult CheckStudent([FromBody] PrecenceAbcenceViewModel model)
        {
            var PrecenceAbcenceStudents = new PrecenceAbcenceS
            {
                CreateDate = DateTime.Now,
                CreateUser = 1,
                IsActivated = true,
                PrecenceOrAbcenceStatus = model.PrecenceOrAbcenceStatus,
            };
            this.dbContext.Set<PrecenceAbcenceS>().Add(PrecenceAbcenceStudents);
            //this.dbContext.SaveChanges();
            return Ok();
        }
    }
}
