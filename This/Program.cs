using System;

namespace This
{
    class Program
    {
        class Employee
        {

            private string Name;
            private string Position;

            public void SetName(string Name)
            {
                this.Name = Name;
            }
            public string GetName()
            {
                return Name;
            }

            public void SetPosition(string Position)
            {
                this.Position = Position;
            }
            public String GetPosition()
            {
                return Position;
            }
        }

        class MyClass
        {
            int a, b, c;

            public MyClass()
            {
                this.a = 5425;
                Console.WriteLine("MyClass()");
            }
            public MyClass(int b):this()
            {
                this.b = b;
                Console.WriteLine($"MyClass({b})");
            }
            public MyClass(int b,int c):this(b)
            {
                this.c = c;
                Console.WriteLine($"MyClass({b}),MyClass({c}) ");
            }
            public void PrintFields()
            {
                Console.WriteLine($"{a},{b},{c}");
            }
            
        }

        static void Main(string[] args)
        {
            #region
            Employee pooh = new();
            pooh.SetName("1");
            pooh.SetPosition("1");


            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");


            Employee pooh2 = new();
            pooh2.SetName("2");
            pooh2.SetPosition("2");

            Console.WriteLine($"{pooh2.GetName()} {pooh2.GetPosition()}");
            #endregion

            MyClass a = new();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new(1);
            b.PrintFields();
            Console.WriteLine();
            MyClass c = new(10,20);
            c.PrintFields();

        }
    }
}
