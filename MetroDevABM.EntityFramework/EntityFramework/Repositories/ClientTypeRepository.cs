using Abp.Domain.Repositories;
using Abp.EntityFramework;
using MetroDevABM.ClientTypes;

namespace MetroDevABM.EntityFramework.Repositories
{
    public class ClientTypeRepository : MetroDevABMRepositoryBase<ClientType, int>, IClientTypeRepository
    {
        public ClientTypeRepository(IDbContextProvider<MetroDevABMDbContext> dbContextProvider)
                : base(dbContextProvider)
        {
        }
    }
}
