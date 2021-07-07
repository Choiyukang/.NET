using System;

namespace Study
{
    class Program
    {
        class MyClass
        {
            public int MyField1;
            public int MyField2;
            public MyClass DeepCopy()
            {
                MyClass newCopy = new()
                {

                    MyField1 = this.MyField1,
                    MyField2 = this.MyField2
                };
                return newCopy;
            }
        }
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
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new()
                {
                    MyField1 = 10,
                    MyField2 = 20
                };

                MyClass target = new()
                {
                    MyField2 = 30
                };

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");

            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new()
                {
                    MyField1 = 10,
                    MyField2 = 20
                };

                MyClass target = new()
                {
                    MyField2 = 30
                };
                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Employee pooh = new Employee();
            pooh.SetName("1");
            pooh.SetPosition("1");
            

        Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");


            Employee pooh2 = new Employee();
            pooh2.SetName("2");
            pooh2.SetPosition("2");

            Console.WriteLine($"{pooh2.GetName()} {pooh2.GetPosition()}");
        }
    }
}

