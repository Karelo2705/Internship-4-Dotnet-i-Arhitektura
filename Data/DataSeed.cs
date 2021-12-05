using Data.Entities;
using Data.Enums;
using NiceApp.Entities;
using NiceApp.Interfaces;

namespace Data
{
    static public class DataSeed
    {
        public static Components[] Comp = new Components[] {
                new Processor {Company = Products.AMD,   CoreNum = 10, Price = 2500},
                new Processor {Company = Products.Intel, CoreNum = 8, Price = 3500},
                new Processor {Company = Products.AMD,   CoreNum = 8, Price = 1500},
                new Processor {Company = Products.Intel, CoreNum = 4, Price = 2500},

                new RAM {Size= 4, Price = 200},
                new RAM {Size= 8, Price =400},

                new Case {Material = Materials.Metal,   Weight = 1.5M, Price = 200},
                new Case {Material = Materials.Plastic, Weight = 1, Price = 100},
                new Case {Material = Materials.Carbon,  Weight = 0.5M, Price = 300},

                new HardDisk {Type = DiskType.HDD, StorageSize= 2, Weight = 2, Price = 500},
                new HardDisk {Type = DiskType.HDD, StorageSize= 1, Weight = 2, Price = 250},
                new HardDisk {Type = DiskType.SSD, StorageSize= 2, Weight = 2, Price = 1500},
                new HardDisk {Type = DiskType.SSD, StorageSize= 1, Weight = 2, Price = 725},

        };
    }
}
