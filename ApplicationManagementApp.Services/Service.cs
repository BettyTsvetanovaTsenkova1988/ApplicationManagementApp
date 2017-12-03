using ApplicationManagementApp.Data;
using ApplicationManagementApp.Models.EntityModels;
using ApplicationManagementApp.Models.ViewModels.Clothes;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagementApp.Services
{
    public abstract class Service
    {
        public Service()
        {
            this.Context = new InventoryManagerContext();
        }

        protected InventoryManagerContext Context { get; }

        public GarmetDetailsVM GetDetails(int? id)
        {
            Garment garmet = this.Context.Clothes.Where(g => g.Id == id).FirstOrDefault();
            GarmetDetailsVM vm = Mapper.Map<Garment, GarmetDetailsVM>(garmet);
            return vm;
        }

        public IEnumerable<AllAvailableClothesVM> GetAllClothes()
        {
            IEnumerable<Garment> list = this.Context.Clothes.Where(g => g.Quantity != 0);
            IEnumerable<AllAvailableClothesVM> vmList = Mapper.Map<IEnumerable<Garment>, IEnumerable<AllAvailableClothesVM>>(list);

            return vmList;
        }
    }
}
