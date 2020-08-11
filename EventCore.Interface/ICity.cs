using EventCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Interface
{
    public interface ICity
    {
        List<City> ListofCity(int? ID);
    }
}