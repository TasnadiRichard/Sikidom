using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{ 
    internal class teglalap : sikidom
{
    public int a;
        public int b;
        public int terulet;
    public int kerulet;

    public teglalap(int a, int b, int terulet, int kerulet)
    {
        this.a = a;
        this.b = b;
        this.terulet = terulet;
        this.kerulet = kerulet;
    }

    public int getA() { return a; }

    public int getB() { return b; }
    public int getTerulet() { this.terulet = this.a * this.b;  return this.terulet; }
    public int getKerulet() { this.kerulet = this.a + this.b * 2; return this.kerulet; }


}
}
