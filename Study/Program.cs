using System;

namespace Study
{
    class Program
    {
        class MyClass {
            public int MyField1;
            public int MyField2;
            public MyClass DeepCopy()
            {
                MyClass newCopy = new MyClass();
                newCopy.MyField1 = this.MyField1;
                newCopy.MyField2 = this.MyField2;
                return newCopy;
            }
        }

        class MyClass2
        {
            public int MyField1;
            public int MyField2;
        }

        static void Main(string[] args)
        {
            MyClass2 myc = new() { MyField1 = 10, MyField2 = 20 };
            MyClass2 myc2 = new() { MyField1 = 30 };

            Console.WriteLine("{0},{1}", myc.MyField1, myc.MyField2);
            Console.WriteLine("{0},{1}", myc2.MyField1, myc2.MyField2);

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

        }
    }
}
