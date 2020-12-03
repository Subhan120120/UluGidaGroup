using System.Collections.Generic;
using UluGidaGroup.Models.Entity;

namespace UluGidaGroup.Models.ViewModel
{
    public class ProductVM
    {
        public ProductVM()
        {
        }

        public ProductVM(List<AppDetail> appDetails)
        {
            this.AppDetails = appDetails;
        }

        public ProductVM(List<AppDetail> appDetails, List<ProductGroup> menuItemGroups)
            : this(appDetails)
        {
            this.ProductGroups = menuItemGroups;
        }

        public List<AppDetail> AppDetails { get; set; }
        public List<ProductGroup> ProductGroups { get; set; }
    }
}