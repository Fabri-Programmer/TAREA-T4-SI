
using EXAMEN_14_11_2024;

Estudiante estudiante1 = new Estudiante();
Cita Cita1 =new Cita();
Estudiante estu1 = new Estudiante();    

int opcion;
Console.WriteLine("*****MENU*********");
Console.WriteLine("CREAR(1): ");
Console.WriteLine("LISTAR(2): ");
Console.WriteLine("MODIFICA MASIVO(3): ");
Console.WriteLine("FIN(4): ");
do
{
    Console.WriteLine("Ingrese una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: estudiante1.Tostring2(); Cita1.Tostring1(); break;
        case 2: Console.Write("Mostrar estudiantes"); 
            foreach (var est in estudiante1) 
            {
                Console.WriteLine(est);
            }
            Console.Write("Mostrar citas"); 
            foreach(var cit in Cita1)
            {
                Console.WriteLine(cit);
            }

            break;

        case 3:
            Console.WriteLine("Ingrese texto a buscar:");
            string busqueda = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo texto para reemplazar:");
            string reemplazo = Console.ReadLine();

            foreach (var est in estudiantes)
            {
                if (est.Universidad.(busqueda))
                {
                    est.Universidad = est.(busqueda, reemplazo);
                }
            }
            Console.WriteLine("Modificaciones completadas.");
            break;

        case 4:
            Console.WriteLine("Fin del programa.");
            return; 
    }

} while (true);
    
            
    
}


} while (opcion =! 0);




   



