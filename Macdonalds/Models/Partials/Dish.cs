using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macdonalds.Models
{
    public partial class Dish
    {
        public string Color {get;set;}
        public int Count
        {
            get
            {
                var elements = App.DB.DishAndElement.Where(x => x.DishId == Id).ToList();

                int sm = 0;
                foreach(var element in elements)
                {
                    sm += (int)element.Count * (int)element.Element.Count;
                }

                return sm;
            }
        }
    }
}
