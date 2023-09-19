using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Kor : sikidom
    {
        public int r;
        public int terulet;
        public int kerulet;
        

        public Kor(int r, int terulet, int kerulet)
        { 
            this.r = r;
            this.terulet = terulet;
            this.kerulet = kerulet;
        }

        public int getr() { return r; }
        public int getterulet() { this.terulet = (int)(r * r * 3.14); return this.terulet; }
        public int getkerulet() { this.kerulet = (int)(r * 2 * 3.14); return this.kerulet; }
    }
}
