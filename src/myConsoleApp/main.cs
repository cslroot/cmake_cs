using System;

using trial_cmake_cs.MyClassLib;
using trial_cmake_cs.MyClassLibBase;


namespace trial_cmake_cs
{

    public class MyConsoleApp
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Hello trial_cmake_cs");

            Foo foo = new();
            Console.WriteLine(foo.GetName());

            Bar bar = new();
            Console.WriteLine(bar.GetName());

            return 0;
        }
    }

}