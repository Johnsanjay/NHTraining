using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjayLibrary
{
   public class Mybaseclass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        internal protected int e; 

        public void MybaseclassMethod()
        {
             a = 2;
             b = 3;
             c = 6;
             d = 7;
             e = 8;
        }
    }

    public class Derivedclass : Mybaseclass
    {
        public void MyderivedclassMethod()
        {
            a = 2;
            b = 3;
            c = 6;
            d = 7;
            e = 8;

        }
    }

    public class Myotherclass
    {
        public void MyotherclassMethod()
        {
            Mybaseclass mb = new Mybaseclass();
            mb.a = 2;
            mb.b = 3;
            mb.c = 6;
            mb.d = 7;
            mb.e = 8;

        }
        

    }
}
