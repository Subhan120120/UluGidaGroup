using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UluGidaGroup.Models.Entity
{
    public class ProductGroup : BaseEntity
    {
        [DisplayName("Grub Adı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [MaxLength(50, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string ProductGroupName { get; set; }

        [DisplayName("Grup Resim")]
        [MaxLength(150, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string ImagePath { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
