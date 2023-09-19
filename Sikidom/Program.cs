using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<sikidom> list = new List<sikidom>();
            sikidom.Add(new Kor());
            sikidom.Add(new teglalap());
            sikidom.Add(new negyzet());
            foreach (var item in sikidom)
        }
    }
}
