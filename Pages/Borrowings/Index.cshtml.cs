using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using budnar_pavel_lab2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace budnar_pavel_lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly budnar_pavel_lab2.Data.budnar_pavel_lab2Context _context;

        public IndexModel(budnar_pavel_lab2.Data.budnar_pavel_lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                    .ThenInclude(b => b.Author)
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}
