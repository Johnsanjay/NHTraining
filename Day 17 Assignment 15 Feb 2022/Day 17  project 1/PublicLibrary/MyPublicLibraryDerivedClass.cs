using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanjayLibrary;

namespace PublicLibrary
{
    public class MyPublicLibraryDerivedClass : Mybaseclass
    {
        public void MyPublicLibraryDerivedClassMethod()
        {
            a = 2;
            b = 3;
            c = 6;
            d = 7;
            e = 8;
        }
    }

    public class MyPublicLibraryOtherClass
    {
        public void MyPublicLibraryOtherClassMethod()
        {
            Mybaseclass mb  = new Mybaseclass();
            mb.a = 2;
            mb.b = 3;
            mb.c = 6;
            mb.d = 7;
            mb.e = 8;
                
        }
    }
}
