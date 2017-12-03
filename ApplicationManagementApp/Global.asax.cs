using ApplicationManagementApp.Models.BindingModels;
using ApplicationManagementApp.Models.EntityModels;
using ApplicationManagementApp.Models.ViewModels.Clothes;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ApplicationManagementApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMappings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMappings()
        {
            Mapper.Initialize(exp =>
            {
                exp.CreateMap<Garment, AllAvailableClothesVM>();
                exp.CreateMap<Garment, GarmetDetailsVM>();
                exp.CreateMap<GarmetBM, Garment>();
                exp.CreateMap<Garment, GarmetBM>();
            });
        }
    }
}
