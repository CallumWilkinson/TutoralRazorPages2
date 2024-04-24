using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutoralRazorPages2.Models;
using TutoralRazorPages2.Services;

namespace TutoralRazorPages2.Pages.Admin.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext context;

        public List<Product> Products { get; set; } = new List<Product>();

        public IndexModel(ApplicationDBContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Products = context.Products.OrderByDescending(p => p.Id).ToList();
        }
    }
}
