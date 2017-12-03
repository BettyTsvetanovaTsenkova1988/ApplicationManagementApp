using ApplicationManagementApp.Models.ViewModels.Clothes;
using ApplicationManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationManagementApp.Controllers
{
   
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        private HomeService service;

        public HomeController()
        {
            this.service = new HomeService();
        }


        [HttpGet]
        [Route("index")]
        public ActionResult Index()
        {
            IEnumerable<AllAvailableClothesVM> availableClothes = this.service.GetAllClothes();

            if (availableClothes.ToList().Count == 0)
            {
                return View("NoAvailableClothes");
            }

            return View(availableClothes);
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("ItemNotFound");
            }

            GarmetDetailsVM garmetDetails = this.service.GetDetails(id);

            if (garmetDetails == null)
            {
                return View("ItemNotFound");
            }

            return View(garmetDetails);

        }
    }
}