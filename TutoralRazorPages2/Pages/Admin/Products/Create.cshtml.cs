using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutoralRazorPages2.Models;

namespace TutoralRazorPages2.Pages.Admin.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ProductDto ProductDto { get; set; } = new ProductDto();
        public void OnGet()
        {
        }
    }
}
