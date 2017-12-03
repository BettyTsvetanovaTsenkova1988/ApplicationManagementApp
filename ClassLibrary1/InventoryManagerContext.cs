using ApplicationManagementApp.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace ApplicationManagementApp.Data
{
    public class InventoryManagerContext : IdentityDbContext<ApplicationUser>
    {

        public InventoryManagerContext()
            : base("data source=HOME\\SQLSERVER;initial catalog=InventoryManagerDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public DbSet<Garment> Clothes { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        public static InventoryManagerContext Create()
        {
            return new InventoryManagerContext();
        }


    }
}