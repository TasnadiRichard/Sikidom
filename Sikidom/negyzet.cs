using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class negyzet : sikidom
    {
        public int a;
        public int terulet;
        public int kerulet;
        
        public negyzet(int a, int terulet, int kerulet)
        {
            this.a = a;
            this.terulet = terulet;
            this.kerulet = kerulet;
        }

        public int getA() { return a; }
        public int getTerulet() { this.terulet = this.a * this.a; return this.terulet; }
        public int getKerulet() { this.kerulet = this.a * 4;  return this.kerulet; }


    }
}
