using Abp.Domain.Repositories;
using Abp.EntityFramework;
using MetroDevABM.Genders;

namespace MetroDevABM.EntityFramework.Repositories
{
    public class GenderRepository : MetroDevABMRepositoryBase<Gender, int>, IGenderRepository
    {
        public GenderRepository(IDbContextProvider<MetroDevABMDbContext> dbContextProvider)
                : base(dbContextProvider)
        {
        }
    }
}
