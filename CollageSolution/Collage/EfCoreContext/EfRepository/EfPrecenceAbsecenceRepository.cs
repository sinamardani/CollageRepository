using Collage.EfCoreContext.ConnectionSetting;
using Collage.Interface;
using Collage.Models;

namespace Collage.EfCoreContext.EfRepository
{
    public class EfPrecenceAbsecenceRepository : IPrecenceAbsecenceRepository
    {
        private readonly DBSContext dbContext;

        public EfPrecenceAbsecenceRepository(DBSContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Stu> GetStudents()
        {
            return dbContext.Students.Where(p => !p.IsDeleted && p.IsActivated).ToList();
        }
    }
}
