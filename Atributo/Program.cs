using Atributo.models;
using Atributo.Service;

namespace Atributo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reflection.First();
            Bread bread = new Baguette(BreadType.Baguette, 2);
            bread.Write();
        }
    }
}