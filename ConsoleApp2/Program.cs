using System;

namespace ConsoleApp2
{
    class Program
    {
        class Configuration
        {
            private readonly int min;
            private readonly int max;

            public Configuration(int v1, int v2)
            {
                min = v1;
                max = v2;
            }
            public void ChangeMax(int newMax)
            {
                //max = newMax;
            }
        }
        static void Main(string[] args)
        {
            Configuration c = new(100,10);
        }
    }
}
