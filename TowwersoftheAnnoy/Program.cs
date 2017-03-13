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
            Peck left = new Peck("Left");
            Peck middel = new Peck("Middel");
            Peck right = new Peck("Right");

            Console.WriteLine("Enter Amount of rings");
            var amountofRings = int.Parse(Console.ReadLine());
            
            int count = amountofRings;
            while(count != 0)
            {
                int size = amountofRings *100;
                Rings ring = new Rings(size);
                left.addRing(ring);
                size = size - 10;
                count--;
            }

            Move(amountofRings, left, right, middel);
            Console.WriteLine(Singletonmfcounting.StaticInstance.count);
            Console.ReadKey();            

        }
         static void Move(int rings, Peck source, Peck destination, Peck spare)
        {
            
            if(rings == 1)
            {
                
                destination.addRing(source.getTopRing());
                Singletonmfcounting.StaticInstance.count++;
            }
            else
            {
                
                Move(rings - 1, source, spare, destination);
                destination.addRing(source.getTopRing());
                Singletonmfcounting.StaticInstance.count++;
                Move(rings - 1, spare, destination, source);

            }          

        }  
        
    }
}
