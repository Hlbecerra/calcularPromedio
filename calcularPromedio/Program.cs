using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float primerNota, segundaNota, tereraNota, promedio;

            Console.Write("Digite su primer nota: ");
            primerNota = float.Parse(Console.ReadLine());
            Console.Write("Digite su segunda nota: ");
            segundaNota = float.Parse(Console.ReadLine());
            Console.Write("Digite su tercera nota: ");
            tereraNota = float.Parse(Console.ReadLine());

            promedio = (primerNota + segundaNota + tereraNota) / 3;

            if(promedio > 3)
            {
                Console.WriteLine("Asignatura aprobada.");
            } else
            {
                Console.WriteLine("Asignatura perdida.");
            }

            Console.ReadKey();
        }
    }
}
