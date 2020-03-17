using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using MetroDevABM.Clients;
using MetroDevABM.ClientTypes;
using MetroDevABM.Genders;

namespace MetroDevABM.EntityFramework
{
    public class MetroDevABMDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MetroDevABMDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MetroDevABMDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MetroDevABMDbContext since ABP automatically handles it.
         */
        public MetroDevABMDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MetroDevABMDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MetroDevABMDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
    }
}
