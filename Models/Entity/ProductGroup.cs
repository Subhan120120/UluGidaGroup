using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UluGidaGroup.Models.Entity
{
    public class ProductGroup : BaseEntity
    {
        [DisplayName("Grub Adı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [MaxLength(40, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string ProductGroupName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
