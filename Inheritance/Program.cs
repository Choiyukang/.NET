using System;

namespace Inheritance
{
    class Program
    {
        class Base
        {
            protected string Name;
            public Base(string Name)
            {
                this.Name = Name;
                Console.WriteLine($"{this.Name}.Base()");
            }
            ~Base()
            {
                Console.WriteLine($"{Name}.BaseMethod()");
            }
            public void BaseMethod()
            {
                Console.WriteLine($"{Name}.BaseMethod()");
            }
        }
        class Deriver : Base
        {
            public Deriver(string Name):base(Name)
            {
                Console.WriteLine($"{ this.Name}.Deriver()");
            }
            ~Deriver()
            {
                Console.WriteLine($"{this.Name}.~Derived()");
            }
            public void DerivedMethod()
            {
                Console.WriteLine($"{Name}.DerivedMethod()");
            }
        }
        

        static void Main(string[] args)
        {
            Base a = new("A");
            a.BaseMethod();

            Deriver b = new("B");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
