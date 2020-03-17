using Abp.Domain.Repositories;
using Abp.EntityFramework;
using MetroDevABM.Clients;

namespace MetroDevABM.EntityFramework.Repositories
{
    public class ClientRepository : MetroDevABMRepositoryBase<Client, int>, IClientRepository
    {
        public ClientRepository(IDbContextProvider<MetroDevABMDbContext> dbContextProvider)
                : base(dbContextProvider)
        {
        }
    }
}
