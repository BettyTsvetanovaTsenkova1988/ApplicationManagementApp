using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationManagementApp.Models.ViewModels.Clothes;
using ApplicationManagementApp.Models.EntityModels;
using AutoMapper;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ApplicationManagementApp.Models.BindingModels;

namespace ApplicationManagementApp.Services
{
    public class AdminService : Service
    {
        public void RemoveById(int id)
        {
            Garment garmet = this.Context.Clothes.Where(g => g.Id == id).FirstOrDefault();

            if (garmet != null)
            {
                garmet.Pictures.Clear();
                this.Context.Clothes.Remove(garmet);
                this.Context.SaveChanges();
            }
        }

        public void CreateGarmet(GarmetBM garmentBM)
        {
            Garment garmet = new Garment();
            GarmetBM garmetBind = garmentBM;

            if (garmentBM != null)
            {
                Mapper.Map<GarmetBM, Garment>(garmetBind);
            }

            garmet.Name = garmetBind.Name;
            garmet.Quantity = garmetBind.Quantity;
            garmet.SinglePrice = garmetBind.SinglePrice;
            garmet.Size = garmetBind.Size;
            garmet.Type = garmetBind.Type;
            garmet.Pictures = new List<Picture>();
            garmet.Description = garmetBind.Description;

            if (garmentBM.Picture1 != null)
            {
                garmet.Pictures.Add(
               new Picture()
               {
                   PictureSourse = String.Format(@"{0}", garmentBM.Picture1.PictureSourse)
               });
            }

            if (garmentBM.Picture2 != null)
            {
                garmet.Pictures.Add(
               new Picture()
               {
                   PictureSourse = String.Format(@"{0}", garmentBM.Picture2.PictureSourse)
               });
            }
            if (garmentBM.Picture3 != null)
            {
                garmet.Pictures.Add(
               new Picture()
               {
                   PictureSourse = String.Format(@"{0}", garmentBM.Picture3.PictureSourse)
               });
            }


            this.Context.Clothes.Add(garmet);
            this.Context.SaveChanges();
        }

        public GarmetDetailsVM GetDetailsBM(int? id)
        {
            Garment garmet = this.Context.Clothes.Where(g => g.Id == id).FirstOrDefault();
            GarmetDetailsVM bm = Mapper.Map<Garment, GarmetDetailsVM>(garmet);
            bm.Name = garmet.Name;
            bm.Quantity = garmet.Quantity;
            bm.SinglePrice = bm.SinglePrice;
            bm.Size = garmet.Size;
            bm.Type = garmet.Type;
            bm.Description = garmet.Description;
            return bm;
        }

        public void CheckState(GarmetBM garmentBM)
        {
            Garment garmet = Mapper.Map<GarmetBM, Garment>(garmentBM);
            this.Context.Entry(garmet).State = EntityState.Modified;
            this.Context.SaveChanges();
        }

        public void DeletePicture(int id)
        {
            Picture pic = this.Context.Pictures.Where(p => p.Id == id).FirstOrDefault();

            if (pic != null)
            {
                this.Context.Pictures.Remove(pic);
                this.Context.SaveChanges();
            }
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
