using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiyuMall.Data.Entities
{
    // product properties
    public class Product
    {
        public int Id { get; set; }
        public String Category { get; set; }
        public String Size { get; set; }
        public String Ram { get; set; }
        public String Storage { get; set; }
        public String Display { get; set; }
        public decimal Price { get; set; }
        public String Title { get; set; }
        public String ProductDescription { get; set; }
        public String ProductID { get; set; }
        public String ItemBrand { get; set; }

    }
}
