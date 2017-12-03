using ApplicationManagementApp.Models.EntityModels;
using ApplicationManagementApp.Models.Enumerations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ApplicationManagementApp.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationManagementApp.Data.InventoryManagerContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationManagementApp.Data.InventoryManagerContext context)
        {
            if (!context.Roles.Any(role => role.Name == "admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("admin");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "viewer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("viewer");
                manager.Create(role);
            }

            context.Clothes.AddOrUpdate(c => c.Id,
                new Garment()
                {
                    Name = "Red dress",
                    Type = GarmetType.Dress,
                    Quantity = 10,
                    Size = Size.S,
                    SinglePrice = 75.50m,
                    Description = "Lace Panel Off The Shoulder Vintage Flare Dress - Wine Red",
                    Pictures = new List<Picture>()
                    {
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\wine\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\wine\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\wine\\3.jpg" }
                    }
                }
            );

            context.Clothes.AddOrUpdate(c => c.Id,
                new Garment()
                {
                    Name = "Dress in flowers",
                    Type = GarmetType.Dress,
                    Quantity = 12,
                    Size = Size.M,
                    SinglePrice = 49.80m,
                    Description = "Lace Panel Off The Shoulder Flowers Flare Dress - Green Flowers",
                    Pictures = new List<Picture>()
                    {
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\flowers\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\flowers\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\flowers\\3.jpg" }
                    }
                }
            );

            context.Clothes.AddOrUpdate(c => c.Id,
               new Garment()
               {
                   Name = "Dress in black and colours",
                   Type = GarmetType.Dress,
                   Quantity = 4,
                   Size = Size.S,
                   SinglePrice = 80.80m,
                   Description = "Lace Panel Off The Shoulder Flowers Flare Dress - Black with Flowers",
                   Pictures = new List<Picture>()
                   {
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\green\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\green\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\green\\3.jpg" }
                   }
               }
           );

            context.Clothes.AddOrUpdate(c => c.Id,
              new Garment()
              {
                  Name = "Dress in black - vintige",
                  Type = GarmetType.Dress,
                  Quantity = 40,
                  Size = Size.S,
                  SinglePrice = 100.00m,
                  Description = "Lace Panel Off The Shoulder Flowers in black - vintige",
                  Pictures = new List<Picture>()
                  {
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\vintige\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\vintige\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\dresses\\vintige\\3.jpg" }
                  }
              }
          );

            context.Clothes.AddOrUpdate(c => c.Id,
               new Garment()
               {
                   Name = "Winter blouse",
                   Type = GarmetType.Blouse,
                   Quantity = 2,
                   Size = Size.L,
                   SinglePrice = 30.00m,
                   Description = "Cold Shoulder Santa Claus Laugh Print T-shirt - Black",
                   Pictures = new List<Picture>()
                   {
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\black\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\black\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\black\\3.jpg" }
                   }
               }
           );

            context.Clothes.AddOrUpdate(c => c.Id,
              new Garment()
              {
                  Name = "Winter blouse in red",
                  Type = GarmetType.Blouse,
                  Quantity = 40,
                  Size = Size.XS,
                  SinglePrice = 35.00m,
                  Description = "Skew Neck Letter Print Christmas Sweatshirt - Red",
                  Pictures = new List<Picture>()
                  {
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\snow\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\snow\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\snow\\3.jpg" }
                  }
              }
          );

            context.Clothes.AddOrUpdate(c => c.Id,
             new Garment()
             {
                 Name = "Winter blouse in red",
                 Type = GarmetType.Blouse,
                 Quantity = 4,
                 Size = Size.M,
                 SinglePrice = 30.00m,
                 Description = "Skew Neck Letter Print Christmas Sweatshirt - white",
                 Pictures = new List<Picture>()
                 {
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\white\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\white\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\blouses\\white\\3.jpg" }
                 }
             }
         );

            context.Clothes.AddOrUpdate(c => c.Id,
              new Garment()
              {
                  Name = "Blue jacket",
                  Type = GarmetType.Outwear,
                  Quantity = 10,
                  Size = Size.S,
                  SinglePrice = 85.00m,
                  Description = "Long Sleeve Pocket Design Winter Padded Coat Jacket - Cadetblue",
                  Pictures = new List<Picture>()
                  {
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\blue\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\blue\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\blue\\3.jpg" }
                  }
              }
          );

            context.Clothes.AddOrUpdate(c => c.Id,
             new Garment()
             {
                 Name = "Brown coat",
                 Type = GarmetType.Outwear,
                 Quantity = 5,
                 Size = Size.M,
                 SinglePrice = 105.00m,
                 Description = "A Line Skirted Coat with Belt - Camel",
                 Pictures = new List<Picture>()
                 {
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\brown\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\brown\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\brown\\3.jpg" }
                 }
             }
         );
            context.Clothes.AddOrUpdate(c => c.Id,
            new Garment()
            {
                Name = "Red coat",
                Type = GarmetType.Outwear,
                Quantity = 15,
                Size = Size.L,
                SinglePrice = 180.00m,
                Description = "A Line Skirted Coat with Belt - Red long",
                Pictures = new List<Picture>()
                {
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\red\\1.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\red\\2.jpg" },
                        new Picture() {PictureSourse = "\\Content\\clothes\\tops\\red\\3.jpg" }
                }
            }
        );

            base.Seed(context);
            context.SaveChanges();
        }
    }
}
