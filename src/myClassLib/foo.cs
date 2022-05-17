using System;

namespace trial_cmake_cs.MyClassLib
{
    public class Foo : MyClassLibBase.Bar
    {
        override public string GetName() { return "Foo Class"; }
    }
}