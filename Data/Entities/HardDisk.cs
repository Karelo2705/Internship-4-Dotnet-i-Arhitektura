using Data.Entities;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceApp.Entities
{
    internal class HardDisk : Components
    {
        public int StorageSize;
        public int Weight;
        public DiskType Type;

        public HardDisk()
        {

        }
        override public TypeOfComp GetTypeOfComp() => TypeOfComp.HardDisk;
        override public string Data()
        {
            var data = $"{StorageSize}TB {Type} {Weight}kg";
                return $"{data}, {Price}kn";
        }
    }
}
