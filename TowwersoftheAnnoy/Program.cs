using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowwersoftheAnnoy
{
    class Program
    {
        static void Main(string[] args)
        {
            Peck left = new Peck();
            Peck middel = new Peck();
            Peck right = new Peck();

            int amountofRings = 3;
            for (int i = amountofRings * 100; i < amountofRings; i++)
            {
                int size = i;
                Rings ring = new Rings(size);
                left.addRing(ring);
                size = size - 10;
            }




        }

        
    }
}
