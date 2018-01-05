using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCT_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HCT_1.Pages
{
    public class AllPersonsModel : PageModel
    {
        private readonly HCT_1.Data.PeopleContext _db;
        public static bool IsPost { get; }

        [BindProperty]
        public IList<People> Persons { get; private set; }

        public AllPersonsModel(HCT_1.Data.PeopleContext db)
        {
            _db = db;
        }

        // Get all persons from DB
        public async Task OnGetAsync()
        {
            var matches = from p in _db.Persons select p;
            Persons = await matches.AsNoTracking().ToListAsync();
        }
    }
}