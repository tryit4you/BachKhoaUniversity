using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BachKhoaUniversity.Models;

namespace BachKhoaUniversity.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly BachKhoaUniversity.Models.BachKhoaUniversityContext _context;

        public DetailsModel(BachKhoaUniversity.Models.BachKhoaUniversityContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
