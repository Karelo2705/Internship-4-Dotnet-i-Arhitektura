using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Components
    {
        public int Price;
        public Products Company;

        public Products GetProducts() => Company;
        public int GetPrice() => Price;

        virtual public string Data()
        {
            throw new NotImplementedException();
        }
        virtual public TypeOfComp GetTypeOfComp()
        {
            throw new NotImplementedException();
        }
     
    }
}
