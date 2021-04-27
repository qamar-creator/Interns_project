using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acclaim_modern
{
    class Calculations
    {
        public static string calculatesavedamount(string price, string discount)

        {

            string p = price;
            int pri = Int32.Parse(p);
            string d = discount;
            int dis = Int32.Parse(d);
            int savedamoun = pri * dis;
            int finale = savedamoun / 100;

            string final = finale.ToString();

            return final;

        }
    }
}
