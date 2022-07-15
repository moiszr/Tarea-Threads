using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Threads
{
    class Threads : Methods
    {
        public override void Cocinar_Arroz()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(i + "-" + "La persona esta coinando Arroz");
                Console.ResetColor();
                Thread.Sleep(500);
            }
        }

        public override void Cocinar_Habichuela()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(i + "-" + "La persona esta coinando Habichuelas");
                Console.ResetColor();
                Thread.Sleep(500);
            }
        }

        public override void Cocinar_Pollo()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.ResetColor();
                Console.WriteLine(i + "-" + "La persona esta cocinando Pollo");
                Thread.Sleep(1000);
            }
        }
    }
}
