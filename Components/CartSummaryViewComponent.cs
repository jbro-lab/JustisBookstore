using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using JustisBookstore.Models;
using JustisBookstore.Infrastructure;


namespace JustisBookstore.Components
{//for cart summary, goes in index
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart Cart)
        {
            cart = Cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
