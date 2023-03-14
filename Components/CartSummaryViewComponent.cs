using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission09_chasejr.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mission09_chasejr.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket cart;
        public CartSummaryViewComponent(Basket cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
