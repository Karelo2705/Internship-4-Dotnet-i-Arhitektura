using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class OrderAdd
    {
       static public List<string> OrderIds { get; set; }

        public static void Set(List<string> newList)
        {
            OrderIds = newList;

        }
    }
}
