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
    public class IndexModel : PageModel
    {
        private readonly BachKhoaUniversity.Models.BachKhoaUniversityContext _context;

        public IndexModel(BachKhoaUniversity.Models.BachKhoaUniversityContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
