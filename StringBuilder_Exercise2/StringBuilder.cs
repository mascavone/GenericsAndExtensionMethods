using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Exercise2
{
    public static class StringBuilder
    {
        public static int CountWorkdsInString(this string str)
        {
            int count;
            string[] allwords = str.Split(null);
            count = allwords.Length;
            return count;
        }
    }
}
