using System;
using System.Collections.Generic;

using System.Text;

namespace AlamoCorp.UWP.Core.Models.Core
{
    public class Product
    {
       
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string MainImageURL { get; set; }
        //public List<string> ImagesURL { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
