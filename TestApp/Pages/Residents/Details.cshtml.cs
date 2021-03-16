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
    public class DetailsModel : PageModel
    {
        private readonly TestApp.Data.KazakhstanContext _context;

        public DetailsModel(TestApp.Data.KazakhstanContext context)
        {
            _context = context;
        }

        public Resident Resident { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Resident = await _context.Residents.FirstOrDefaultAsync(m => m.ID == id);

            if (Resident == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
