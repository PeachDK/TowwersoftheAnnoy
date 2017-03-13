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
        public string Label { get; set; }
            
        public Peck(string label)
        {
            this.Label = label;
            holdingRings = new Stack<Rings>();
        }

        public void addRing(Rings ring)
        {           
                holdingRings.Push(ring);
                              
        }

        public Rings getTopRing()
        {
            if(holdingRings.Count == 0)
            {
                return null;
            }
            else
            {
                return holdingRings.Pop();
            }

        }

        public bool isEmpty()
        {
            return holdingRings.Any();
        }
        
        public Rings GettopRingWithoutRemoving()
        {
            Rings tempring = new Rings(-1);
            if (holdingRings.Count == 0)
            {
                return tempring;
            }
            else
            {
                return holdingRings.Peek();
            }
        }


        public bool CanbeAdded(Rings ring)
        {
            if(GettopRingWithoutRemoving().Size > ring.Size || ring.Size == -1)
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }

        
        
    }
}
