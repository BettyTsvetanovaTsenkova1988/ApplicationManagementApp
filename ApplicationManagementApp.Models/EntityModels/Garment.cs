using ApplicationManagementApp.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagementApp.Models.EntityModels
{
    public class Garment
    {
        private ICollection<Picture> pictures;

        public Garment()
        {
            this.pictures = new HashSet<Picture>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public GarmetType Type { get; set; }
        public int Quantity { get; set; }
        public Size Size { get; set; }
        public decimal SinglePrice { get; set; }
        public virtual ICollection<Picture> Pictures
        {
            get { return this.pictures; }
            set { this.pictures = value; }
        }
        public string Description { get; set; }


    }
}
