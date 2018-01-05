using HCT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCT_1.Interfaces
{
    public interface IDataRepository 
    {
        People getById(int id);
        void Add(People p);
        List<People> List();
        void Delete(People p);
    }
}
