using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_n_Enums
{
    enum cities { Bangalore = 1, Agra = 0, Chennai = 2, Vizag = 4, Hyderabad = 3 }
    internal class EnumEg
    {
        public static void EnumOps()
        {
            //understand enumerations
            Console.WriteLine("Hi Enums");
            foreach (int c in Enum.GetValues(typeof(cities)))
            {
                // Console.WriteLine(c);
                if (c == 1) Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "Is a Garden City");
                else if (c == 2) Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + " Is a Temple City");
            }
            Console.WriteLine("-----------------------");
            foreach (var x in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(x);
            }
        }
    }
}
