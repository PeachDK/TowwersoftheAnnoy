using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowwersoftheAnnoy
{
 public class Peck
    {
        Stack<Rings> holdingRings; 
            
        public Peck()
        {
            holdingRings = new Stack<Rings>();
        }

        public int addRing(Rings ring)
        {
            if (holdingRings.Peek().Size > ring.Size)
            {
                return -1;
            }
            else
            {
                holdingRings.Push(ring);
                return 1;
            }    
        }

        public Rings getTopRing()
        {
            return holdingRings.Pop();
        }

        

    }
}
