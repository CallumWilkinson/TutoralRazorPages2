using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutoralRazorPages2.Services;

namespace TutoralRazorPages2.Pages.Admin.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDBContext context;

        public DeleteModel(IWebHostEnvironment environment, ApplicationDBContext context)
        {
            this.environment = environment;
            this.context = context;
        }


        public void OnGet(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/Admin/Products/Index");
                return;
            }

            var product = context.Products.Find(id);

            if (product == null)
            {
                Response.Redirect("/Admin/Products/Index");
                return;
            }

            //delete image file from database
            string imagePath = environment.WebRootPath + "/CrudAppImages/" + product.ImageFileName;
            System.IO.File.Delete(imagePath);

            context.Products.Remove(product);
            context.SaveChanges();

            Response.Redirect("/Admin/Products/Index");
            
        }
    }
}
