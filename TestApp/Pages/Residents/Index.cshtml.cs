using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestApp.Data;
using TestApp.Models;

namespace TestApp.Pages.Residents
{
    public class IndexModel : PageModel
    {
        private readonly TestApp.Data.KazakhstanContext _context;

        public IndexModel(TestApp.Data.KazakhstanContext context)
        {
            _context = context;
        }

        public IList<Resident> Resident { get;set; }

        public async Task OnGetAsync()
        {
            Resident = await _context.Residents.ToListAsync();
        }
    }
}
