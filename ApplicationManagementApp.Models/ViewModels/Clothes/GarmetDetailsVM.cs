using ApplicationManagementApp.Models.EntityModels;
using ApplicationManagementApp.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagementApp.Models.ViewModels.Clothes
{
    public class GarmetDetailsVM
    {
        public int Id { get; set; }

        [Display(Name = "Name of product")]
        public string Name { get; set; }

        [Display(Name = "Type of product")]
        public GarmetType Type { get; set; }

        [Display(Name = "Available quantity")]
        public int Quantity { get; set; }

        public Size Size { get; set; }

        [Display(Name = "Single Price in BGN")]
        public decimal SinglePrice { get; set; }

        public string Description { get; set; }

        public ICollection<Picture> Pictures { get; set; }
    }
}
