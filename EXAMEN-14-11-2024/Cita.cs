using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_14_11_2024
{
    public class Cita
    {
        public int numero  { get; set; }
        public string estudiante { get; set; }
        public string enfermedad { get; set; }

        public double precio { get; set; }

        public void Tostring1()
        {
            Console.Write("Cual es tu numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Cual es tu enfermedad: ");
            enfermedad = Console.ReadLine();
            Console.Write("Precio: ");
            precio=double.Parse(Console.ReadLine());
        }

        public void mostrar()
        {
            //Datos:
            foreach(var mostrar in estudiante)
            {
                Console.Write(mostrar);
            }
        }


    }
}
