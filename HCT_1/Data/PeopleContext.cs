using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCT_1.Models;
using Microsoft.EntityFrameworkCore;

namespace HCT_1.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
        }

        public DbSet<People> Persons { get; set; }
    }
}
