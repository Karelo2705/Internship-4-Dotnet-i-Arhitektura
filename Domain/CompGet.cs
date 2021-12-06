using Data;
using Data.Entities;
using Data.Enums;
using System.Linq;

namespace Domain.Entities
{
    public class CompGet
    {
        static public Components[] GetByType(TypeOfComp comp)
        {
            return DataSeed.Comp.Where(c => c.GetTypeOfComp() == comp).ToArray();
        }
    }
}
