using System;
using System.Collections.Generic;
using System.Text;

namespace thegioitruyenx.data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCout { set; get; }
        public string DateCreate { set; get; }
        public string SeoAlias { set; get; }

        public List<ProductInCategory> ProductInCategories { set; get; }
    }
}
