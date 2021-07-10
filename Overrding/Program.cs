using System;

namespace Overrding
{
    class Program
    {
        class ArmorSuite
        {
            public virtual void Initialize()
            {
                Console.WriteLine("Armored");
            }
        }
       
        class IronMan : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Armored");
            }
        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Doubll arasdas");
                Console.WriteLine("Micro-Roket");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Createing ArmorSuite ");
            ArmorSuite armor = new();
            armor.Initialize();

            Console.WriteLine("\nCreate IronMan");
            ArmorSuite iron = new();
            iron.Initialize();

            Console.WriteLine("\n Creating WarMachine");
            ArmorSuite warmachine = new();
            warmachine.Initialize();

        }
    }
}