using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using HCT_1.Interfaces;
using HCT_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HCT_1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HCT_1.Data.PeopleContext _db;
        public static bool IsPost { get; }

        public IndexModel(HCT_1.Data.PeopleContext db)
        {
            _db = db;
        }

        public IList<People> Persons { get; set; }

        [BindProperty]
        public string SearchString { get; set; }

        [BindProperty]
        public IList<People> MatchedPerson { get; set; }

        public async Task OnGetAsync()
        {
            if (!IsPost)
            {
                var matches = from p in _db.Persons select p;

                if (!String.IsNullOrEmpty(SearchString))
                {
                    matches = matches.Where(s => s.Name.Contains(SearchString));
                    Persons = await matches.ToListAsync();
                }
            }
        }

        public async Task OnPost()
        {
            var persons = from p in _db.Persons select p;
            if (!String.IsNullOrEmpty(SearchString))
            {
                persons = persons.Where(s => s.Name.Contains(SearchString));
                MatchedPerson = await persons.ToListAsync();
            }
        }
    }
}
