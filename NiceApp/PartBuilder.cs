using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Enums;

namespace NiceApp
{
    class ChooseComponents
    {

        public static Components[] TypeChoose()
        {
            var components = new List<Components> { };
            var componentTypes = Enum.GetValues(typeof(TypeOfComp)).Cast<TypeOfComp>();

            foreach (var componentType in componentTypes)
            {
                Console.WriteLine(componentType);
            }

            return components.ToArray();
        }
    }
}