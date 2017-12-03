using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagementApp.Models.EntityModels
{
    public class Picture
    {
        public int Id { get; set; }
        public string PictureSourse { get; set; }
        public virtual Garment Garmet { get; set; }

    }
}
