using MetroDevABM.ClientTypes;
using MetroDevABM.EntityFramework;
using MetroDevABM.Genders;
using System.Data.Entity.Migrations;

namespace MetroDevABM.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MetroDevABM.EntityFramework.MetroDevABMDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MetroDevABMDb";
        }

        protected override void Seed(MetroDevABM.EntityFramework.MetroDevABMDbContext context)
        {
            context.ClientTypes.AddOrUpdate(
                p => p.Title,
                new ClientType { Title = "Persona Física" },
                new ClientType { Title = "Persona Moral" }
                );
            context.Genders.AddOrUpdate(
                p => p.Title,
                new Gender { Title = "Masculino" },
                new Gender { Title = "Femenino" }
                );
        }
    }
}
