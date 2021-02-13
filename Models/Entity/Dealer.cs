using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UluGidaGroup.Models.Entity
{
    public class Dealer : BaseEntity
    {
        [DisplayName("Bayi Adı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [MaxLength(100, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string Name { get; set; }

        [DisplayName("Site")]
        [MaxLength(100, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string SiteUrl { get; set; }

        [DisplayName("Grup Resim")]
        [MaxLength(150, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string ImagePath { get; set; }

        public int OrderNumber { get; set; }

    }
}
