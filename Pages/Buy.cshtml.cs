using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JustisBookstore.Infrastructure;
using JustisBookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JustisBookstore.Pages.Shared
{
    public class BuyModel : PageModel
    {//for Buy razor page
        private IBookRepository repository;

        public BuyModel (IBookRepository repo, Cart cart)
        {
            repository = repo;
            Cart = cart;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {//called when someone clicks on "buy" in index, will add book to cart
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);
          
            Cart.AddItem(book, 1);

            

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {//called when someone tries to remove book from cart
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookId == bookId).Book);
           
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
