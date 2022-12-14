using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using budnar_pavel_lab2.Models;
using budnar_pavel_lab2.Pages.ViewModels;

namespace budnar_pavel_lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly budnar_pavel_lab2.Data.budnar_pavel_lab2Context _context;

        public IndexModel(budnar_pavel_lab2.Data.budnar_pavel_lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;
        public CategoryIndexData CategoryData { get; set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category.Include(i => i.BookCategories).ThenInclude(c => c.Book).ThenInclude(a => a.Author).ToListAsync();

            if(id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories.Where(i => i.ID == id).Single();
                CategoryData.BookCategories = category.BookCategories;
            }

            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
