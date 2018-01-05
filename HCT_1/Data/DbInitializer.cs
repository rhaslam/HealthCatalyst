using HCT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace HCT_1.Data
{
    public class DbInitializer
    {
        public static void Initialize(PeopleContext context)
        {

            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Persons.Any())
            {
                return;   // DB has been seeded
            }

            var person = new People[]
            {
                new People{Name="George Michael", Address="1 Maui Way Lihui Hawaii", Age=48, Interests="music, napping",Photo="Bert.jpg"},
                new People{Name="Jeff Immelt",Address="192 Bad Chairmen Drive", Age=68, Interests="isolation beach",Photo="Bird.jpg"},
                new People{Name="Ralph Apple",Address="123 First North", Age=82, Interests="Baseball, Gambling",Photo="Black.jpg"},
                new People{Name="Ralph Cramden",Address="192 E 42 Street New York, New York", Age=72, Interests="drinking, fotball, opera",Photo="Blue.jpg"},
                new People{Name="Randi Mangostein",Address="62 First North", Age=36, Interests="Sewing, Shopping",Photo="Cookie.jpg"},
                new People{Name="Sam Twingle",Address="192 S Park Street South Bridgeport CT", Age=19, Interests="skydiving, comics",Photo="Ernie.jpg"},
                new People{Name="Sandy Mango",Address="555 First North", Age=18, Interests="Softball,   Ballet",Photo="Ninja.jpg"},
                new People{Name="Steve Pineapple",Address="4 Nineth South", Age=22, Interests="Canyoning,   Hiking,   Sking",Photo="Orange.jpg"},
                new People{Name="Stevenapolis Red Apple",Address="345 Seventh North", Age=82, Interests="Baseball, Gambling",Photo="Pink.jpg"}

            };
            foreach (People s in person)
            {
                context.Persons.Add(s);
            }
            context.SaveChanges();
        }
    }
}
