using Data.Entities;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceApp.Interfaces
{
    class Processor : Components
    {
        public int CoreNum;
        public Products Company;

        public Processor() 
        {
            
        }
        override public TypeOfComp GetTypeOfComp() => TypeOfComp.Processor;
        override public string Data()
        {
            var data = $"{Company}, {CoreNum} jezgre";
            return $"{data}, {Price}kn";
        }
    }
}
