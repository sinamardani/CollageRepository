using Collage.EfCoreContext.ConnectionSetting;
using Collage.Interface;
using Collage.Models;
using Collage.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var selectedPrecence = dbContext.Set<PrecenceAbcenceS>().Where(p => !p.IsDeleted)
                .SingleOrDefault(p => p.StudentId == model.StudentId);
            if (selectedPrecence != null)
            {
                selectedPrecence.IsUpdated = true;
                selectedPrecence.UpdatedDate = DateTime.Now;
                selectedPrecence.ID = model.StudentId;
                selectedPrecence.PrecenceOrAbcenceStatus = model.PrecenceOrAbcenceStatus;
                this.dbContext.Set<PrecenceAbcenceS>().Update(selectedPrecence);
            }
            else
            {
                var precenceAbcenceStudents = new PrecenceAbcenceS
                {
                    CreateDate = DateTime.Now,
                    CreateUser = 1,
                    IsActivated = true,
                    PrecenceOrAbcenceStatus = model.PrecenceOrAbcenceStatus,
                    StudentId = model.StudentId,
                };
                this.dbContext.Set<PrecenceAbcenceS>().Add(precenceAbcenceStudents);
            }
            this.dbContext.SaveChanges();
            return Ok();

        }
    }
}
