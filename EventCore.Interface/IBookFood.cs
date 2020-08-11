using EventCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Interface
{
    public interface IBookFood
    {
        IEnumerable<Food> FoodList(Food Food);
        int BookFood(BookingFood Food);
    }
}
