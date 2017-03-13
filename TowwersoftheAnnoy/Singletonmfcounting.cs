using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowwersoftheAnnoy
{
    class Singletonmfcounting
    {
        //Singleton 
        private static readonly Singletonmfcounting _staticinstance = new Singletonmfcounting();
        public static Singletonmfcounting StaticInstance
        {
            get
            {
                return _staticinstance;
            }
        }

        public int count { get; set; }

        private Singletonmfcounting()
        {
            this.count = 0;
        }

    }
}
