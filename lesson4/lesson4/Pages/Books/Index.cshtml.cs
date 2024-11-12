using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lesson4.Data;
using lesson4.Models;

namespace lesson4.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly lesson4.Data.lesson4Context _context;

        public IndexModel(lesson4.Data.lesson4Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
