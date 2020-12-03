using UluGidaGroup.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UluGidaGroup.Models.Entity
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
