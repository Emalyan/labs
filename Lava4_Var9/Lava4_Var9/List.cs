using System;
using System.Collections.Generic;
using System.Text;

namespace Lava4_Var9
{
    public class List : List<string>
    {
        public static List operator +(List listOne, List listTwo)
        {
            var result = new List();
            result.AddRange(listOne);
            result.AddRange(listTwo);
            return result;
        }

        public static bool operator !=(List listOne, List listTwo)
        {
            return true;
        }

        public static bool operator ==(List listOne, List listTwo)
        {
            return true;
        }
    }
}
