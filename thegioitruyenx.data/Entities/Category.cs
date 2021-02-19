using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Enums;

namespace thegioitruyenx.data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int SortOder { set; get; }
        public Boolean IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        //public List<> CategoryTranslations { set; get; }

        public List<ProductInCategory> ProductInCategories { set; get; }
    }
}
