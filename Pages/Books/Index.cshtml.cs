using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using budnar_pavel_lab2.Data;
using budnar_pavel_lab2.Models;

namespace budnar_pavel_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly budnar_pavel_lab2.Data.budnar_pavel_lab2Context _context;

        public IndexModel(budnar_pavel_lab2.Data.budnar_pavel_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
            }
        }
    }
}
