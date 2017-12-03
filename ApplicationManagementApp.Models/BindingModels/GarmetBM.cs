using ApplicationManagementApp.Models.EntityModels;
using ApplicationManagementApp.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagementApp.Models.BindingModels
{
    public class GarmetBM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public GarmetType Type { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Size Size { get; set; }

        [Required]
        public decimal SinglePrice { get; set; }

        [Required]
        public string Description { get; set; }

        public Picture Picture1 { get; set; }
        public Picture Picture2 { get; set; }
        public Picture Picture3 { get; set; }
    }
}
