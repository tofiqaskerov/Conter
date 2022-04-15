using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conter.Helper
{
    public class gazhesablama
    {
        public void calc(decimal gaz, decimal limitQiymet, decimal illikLimit)
        {
            decimal netice;
            Console.WriteLine("serfiyyati daxil edin: ");
            var serfiyyat = Console.ReadLine();


            if (Convert.ToDecimal(serfiyyat) > illikLimit)
            {
                decimal serfiyyatDec = Convert.ToDecimal(serfiyyat);
                netice = (serfiyyatDec - illikLimit) * limitQiymet + gaz * illikLimit;
                Console.WriteLine(netice);
            }
            else
            {
                Console.WriteLine("yanlisdir");
            }
        }


    }
}
