using Data.Entities;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceApp.Entities
{
    public class RAM :Components
    {
        public int Size;

        public RAM()
        {

        }
        override public TypeOfComp GetTypeOfComp() => TypeOfComp.RAM;
        override public string Data()
        {
            var data = $" card od {Size}GB";
            return $"{data}, {Price}kn";
        }
    }
   
}
