using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Struct_n_Enums
{
    internal class Program
    {
        struct Student
        {
            public int v1;
            public float v2;
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                s.v1 = 10; s.v2 = 20;
                Console.WriteLine("the S has : " + s.v1 + s.v2);

                Student s2 = new Student();
                s2 = s;  //assigning the values of s to s2
                Console.WriteLine("the S2 has : " + s2.v1 + s2.v2);

                s.v1 = 50;
                Console.WriteLine("After reassigning ...");
                Console.WriteLine(s.v1 + s.v2);
                Console.WriteLine(s2.v1 + s2.v2);

                s2.v2 = 100;

                Console.WriteLine("After reassigning 2nd time ...");
                Console.WriteLine(s.v1 + s.v2);
                Console.WriteLine(s2.v1 + s2.v2);
                Console.ReadLine();
            }
        }
    }
}
