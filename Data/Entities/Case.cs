using Data.Entities;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceApp.Entities
{
     class Case :Components
    {
        public Materials Material;
        public decimal Weight;

        public Case()
        {

        }
        override public TypeOfComp GetTypeOfComp() => TypeOfComp.Case;
        override public string Data()
        {
            var data = $"{Material}({Weight}) ";
            return $"{data}, {Price}";
        }
    }
}
