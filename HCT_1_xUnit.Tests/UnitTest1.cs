using HCT_1.Pages;
using HCT_1.Models;
using Xunit;
using HCT_1.Data;
using System.Collections.Generic;
using System.Linq;

namespace HCT_1_xUnit.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllPersons()
        {
            List<People> allPersons= null;
            using (var context = new PeopleContext())
            {
                var matches = from p in context.Persons select p;
                allPersons = matches.ToList();
            }
            Assert.Equal(9, allPersons.Count);
        }

    }
}

