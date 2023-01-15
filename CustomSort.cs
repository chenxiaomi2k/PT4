using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest4
{
    internal class CustomSort : IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {
            if (x == null)
                return (y == null) ? 0 : 1;

            if (y == null)
                return -1;

            Movie m1 = x as Movie;
            Movie m2 = y as Movie;

            // Uncomment this to sort by Name 
            // return( (new CaseInsensitiveComparer()).Compare( p1.Name, p2.Name) );

            return ((int)(m1.AvarageRate - m2.AvarageRate));
        }
    }
}
