using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ingresa la calificacion de la primer materia");
            double c1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("ingresa la calificacion de la segunda materia");
            double c2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("ingresa la calificacion de la tercera materia");
            double c3 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("ingresa la calificacion de la cuarta materia");
            double c4 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("ingresa la calificacion de la quinta materia");
            double c5 = double.Parse(Console.ReadLine());
            double CF = (c1 + c2 + c3 + c4 + c5)/5;
            if(CF >= 6)
            {
                System.Console.WriteLine("tu promedio es:"+CF);
                System.Console.WriteLine("tu calificacion es aprobatoria");

            }
            else 
            {
                System.Console.WriteLine("su calificacion es:"+CF);
                System.Console.WriteLine("su calificacion es reprobatoria");
            }
            Console.ReadKey();
        }

    }
}
