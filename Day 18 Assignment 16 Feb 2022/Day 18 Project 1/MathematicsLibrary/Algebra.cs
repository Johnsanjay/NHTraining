using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class Algebra
    {
        public  static bool IsPalindrome(int input)
        {
            int rev=0, rem,m;

            m = input;

            while (m > 0)
            {
                rem = m % 10;
                rev = (rev * 10) + rem;
               m = m / 10;
            }
            if (input == rev)

                return true;
            else
                
            return false;

        }

    }
    
}
