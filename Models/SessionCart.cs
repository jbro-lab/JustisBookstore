using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using JustisBookstore.Infrastructure;

namespace JustisBookstore.Models.ViewModels
{
    public class SessionCart : Cart
    {//makes it so you can keep track of a cart during a session
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
       
        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Book book, int quantity)
        {//so we can add books to Session cart, but also adds to Cart
            base.AddItem(book, quantity);
            Session.SetJson("Cart", this);
        }
        public override void RemoveLine(Book book)
        {//like add but remove
            base.RemoveLine(book);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {//like add but clear
            base.Clear();
            Session.Remove("Cart");
        }

    }
}



