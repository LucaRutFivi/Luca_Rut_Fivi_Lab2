﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Luca_Rut_Fivi_Lab2.Data;
using Luca_Rut_Fivi_Lab2.Models;

namespace Luca_Rut_Fivi_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Luca_Rut_Fivi_Lab2.Data.Luca_Rut_Fivi_Lab2Context _context;

        public IndexModel(Luca_Rut_Fivi_Lab2.Data.Luca_Rut_Fivi_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
