using System;

namespace ConsoleApp1
{
    class Program
    {
        class Base
        {
            public void MyMethod()
            {
                Console.WriteLine
                    ("Base Mymethod()");
            }
        }

        class Derived : Base
        {
            public new void MyMethod()
            {
                Console.WriteLine("Base Mymethod()11");
            }
        }

        static void Main(string[] args)
        {
            Base baseObj = new();
            baseObj.MyMethod();

            Derived de = new();
            de.MyMethod();

            Base baseDerivedr = new();
            baseDerivedr.MyMethod();

        }
    }
}
