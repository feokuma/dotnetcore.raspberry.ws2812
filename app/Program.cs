using System;
using rpi_ws281x;
using System.Drawing;
using System.Threading;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var settings = Settings.CreateDefaultSettings();

            //Use 16 LEDs and GPIO Pin 18.
            //Set brightness to maximum (255)
            //Use Unknown as strip type. Then the type will be set in the native assembly.
            settings.Channels[0] = new Channel(12, 18, 255, false, StripType.WS2812_STRIP);

            using (var rpi = new WS281x(settings))
            {
                while (true)
                {
                    // draw an X
                    rpi.SetLEDColor(0, 0, Color.Red);
                    rpi.SetLEDColor(0, 2, Color.Red);
                    rpi.SetLEDColor(0, 4, Color.Red);
                    rpi.SetLEDColor(0, 6, Color.Red);
                    rpi.SetLEDColor(0, 8, Color.Red);
                    rpi.Render();
                    Thread.Sleep(3000);
                    // clean
                    rpi.SetLEDColor(0, 0, Color.Black);
                    rpi.SetLEDColor(0, 2, Color.Black);
                    rpi.SetLEDColor(0, 4, Color.Black);
                    rpi.SetLEDColor(0, 6, Color.Black);
                    rpi.SetLEDColor(0, 8, Color.Black);
                    rpi.Render();

                    for (int i = 0; i < 10; i++)
                    {
                        rpi.SetLEDColor(0, 2, Color.Black);
                        rpi.SetLEDColor(0, 6, Color.Black);
                        rpi.SetLEDColor(0, 1, Color.Blue);
                        rpi.SetLEDColor(0, 4, Color.Blue);
                        rpi.SetLEDColor(0, 7, Color.Blue);
                        rpi.Render();
                        Thread.Sleep(150);

                        rpi.SetLEDColor(0, 1, Color.Black);
                        rpi.SetLEDColor(0, 7, Color.Black);
                        rpi.SetLEDColor(0, 0, Color.Blue);
                        rpi.SetLEDColor(0, 8, Color.Blue);
                        rpi.Render();
                        Thread.Sleep(150);

                        rpi.SetLEDColor(0, 0, Color.Black);
                        rpi.SetLEDColor(0, 8, Color.Black);
                        rpi.SetLEDColor(0, 3, Color.Blue);
                        rpi.SetLEDColor(0, 5, Color.Blue);
                        rpi.Render();
                        Thread.Sleep(150);

                        rpi.SetLEDColor(0, 3, Color.Black);
                        rpi.SetLEDColor(0, 5, Color.Black);
                        rpi.SetLEDColor(0, 2, Color.Blue);
                        rpi.SetLEDColor(0, 6, Color.Blue);
                        rpi.Render();
                        Thread.Sleep(150);
                    }
                    
                    // clean
                    rpi.SetLEDColor(0, 2, Color.Black);
                    rpi.SetLEDColor(0, 4, Color.Black);
                    rpi.SetLEDColor(0, 6, Color.Black);
                    rpi.Render();

                    // draw checked
                    rpi.SetLEDColor(0, 1, Color.Green);
                    rpi.SetLEDColor(0, 3, Color.Green);
                    rpi.SetLEDColor(0, 7, Color.Green);
                    rpi.SetLEDColor(0, 11, Color.Green);
                    rpi.Render();
                    Thread.Sleep(3000);

                    // clean
                    rpi.SetLEDColor(0, 1, Color.Black);
                    rpi.SetLEDColor(0, 3, Color.Black);
                    rpi.SetLEDColor(0, 7, Color.Black);
                    rpi.SetLEDColor(0, 11, Color.Black);
                    rpi.Render();
                }
            }
        }
    }
}