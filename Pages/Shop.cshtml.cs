using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_chasejr.Infrastructure;
using Mission09_chasejr.Models;

namespace Mission09_chasejr.Pages
{
    public class ShopModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }
        public ShopModel (IBookstoreRepository temp)
        {
            repo = temp;
        }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {

            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(b, 1);

            HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
