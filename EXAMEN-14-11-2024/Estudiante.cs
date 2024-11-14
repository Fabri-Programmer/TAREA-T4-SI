using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_14_11_2024
{
    public class Estudiante
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public string universidad { get; set; }


        public void Tostring2()
        {
            Console.Write("Cual es tu codigo: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Cual es tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Donde es tu universidad: ");
            universidad = Console.ReadLine();

        }
        public void eliminar1(string uni)
        {
            int posicion = 0;
            int indice = Array.IndexOf(tarea,uni );
            if (indice != -1)
            {
                for (int i = indice; i < universidad.Length - 1; i++)
                {
                    universidad[i] = universidad[i + 1];
                }
                Array.Resize(ref universidad, universidad.Length - 1);
                posicion--;
            }
    
    
}
