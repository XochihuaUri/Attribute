using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributo.models
{
    public class Baguette : Bread
    {
        public Baguette(string name, int price) : base(name, price)
        {
        }

        public Baguette(BreadType name, int price) : base(name, price)
        {
        }

        public Baguette(BreadType name, int price, int taxes) : base(name, price, taxes)
        {
        }

        public override void Make()
        {
            throw new NotImplementedException();
        }
    }
}
