using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApplicationManagementApp.Data;
using ApplicationManagementApp.Models.EntityModels;
using ApplicationManagementApp.Services;
using ApplicationManagementApp.Models.ViewModels.Clothes;
using ApplicationManagementApp.Models.BindingModels;

namespace ApplicationManagementApp.Areas.Admin.Controllers
{
    [RouteArea("admin")]
    [RoutePrefix("clothes")]
    [Authorize(Roles = "admin")]
    public class ClothesController : Controller
    {

        private AdminService service;
        public ClothesController()
        {
            this.service = new AdminService();
        }

        [HttpGet]
        [Route("all")]
        public ActionResult All()
        {
            IEnumerable<AllAvailableClothesVM> allist = this.service.GetAllClothes();

            if (allist == null)
            {
                return View("NoAvailableClothes");
            }

            return View(allist.ToList());
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("ItemNotFound");
            }

            GarmetDetailsVM garment = this.service.GetDetails(id);

            if (garment == null)
            {
                return View("ItemNotFound");
            }
            return View(garment);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GarmetBM garment)
        {
            if (ModelState.IsValid)
            {
                this.service.CreateGarmet(garment);
                return RedirectToAction("All");
            }

            return View(garment);
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("ItemNotFound");
            }

            GarmetDetailsVM garment = this.service.GetDetailsBM(id);

            if (garment == null)
            {
                return View("ItemNotFound");
            }

            return View(garment);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public ActionResult Edit(GarmetBM garment)
        {
            if (ModelState.IsValid)
            {
                this.service.CheckState(garment);

                return RedirectToAction("All");
            }
            return View(garment);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("ItemNotFound");
            }

            GarmetDetailsVM garment = this.service.GetDetails(id);

            if (garment == null)
            {
                return View("ItemNotFound");
            }
            return View(garment);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GarmetDetailsVM garment = this.service.GetDetails(id);
            this.service.RemoveById(id);
            return RedirectToAction("All");
        }

        public ActionResult UpdateGalery(int id)
        {

            this.service.DeletePicture(id);

            return RedirectToAction("All");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.service.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
