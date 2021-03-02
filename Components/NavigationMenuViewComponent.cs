using JustisBookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustisBookstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            //allows to filter by category
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Books
                .Select(book => book.category)
                .Distinct()
                .OrderBy(book => book));
        }
    }
}
