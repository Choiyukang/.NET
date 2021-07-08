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

            
        }
    }
}

