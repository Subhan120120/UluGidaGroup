using Microsoft.AspNetCore.Mvc;
using UluGidaGroup.AppCode.Helpers;
using UluGidaGroup.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace UluGidaGroup.AppCode.ViewComponents
{
    [ViewComponent]
    public class CartCount : ViewComponent
    {
        public IViewComponentResult InvokeAsync()
        {
            List<Order> cart = SessionHelper.GetObjectFromJson<List<Order>>(HttpContext.Session, "cart");
            int cartCount = 0;
            if (cart != null)
            {
                cartCount = cart.Sum(item => item.Quantity);
            }
            return View(cartCount);
        }
    }
}
