using System;

namespace AccessModifier
{
    class Program
    {
        class WaterHeater
        {
            protected int temperature;
            public void SetTemperature(int temperature)
            {
                if (temperature < -5 || temperature > 42)
                    throw new Exception("Out of temperature range");
                this.temperature = temperature;
            }
            internal void TurnOnwater()
            {
                Console.WriteLine($"turn on water : {temperature}");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new();
                heater.SetTemperature(20);
                heater.TurnOnwater();

                heater.SetTemperature(-2);
                heater.TurnOnwater();

                heater.SetTemperature(50);
                heater.TurnOnwater();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
