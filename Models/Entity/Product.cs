using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UluGidaGroup.Models.Entity
{
    public class Product : BaseEntity
    {
        [DisplayName("Ürün Adı")]
        [MaxLength(40,ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        public string ProductName { get; set; }

        [DisplayName("Ürün Açıklaması")]
        [MaxLength(50, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string ProductDescription { get; set; }

        [DisplayName("Fiyatı")]
        [Range(0.01, 200.00, ErrorMessage = "{0} {1} - {2} aralığında olmalıdır.")]
        [DataType(DataType.Currency, ErrorMessage = "{0} üçün uyğun format daxil edilməlidir.")]
        //[DisplayFormat(DataFormatString = "{0:C0}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }

        [DisplayName("Resim")]
        [MaxLength(150, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string ImagePath { get; set; }

        [DisplayName("Grubu")]
        [Required(ErrorMessage = "Boş buraxıla bilməz.")]
        public int ProductGroupId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
        public virtual List<Order> Orders { get; set; }

        public int OrderNumber { get; set; }
    }
}
