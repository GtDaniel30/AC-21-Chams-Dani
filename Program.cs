internal class Program
{
    static string[] nave = { "HALCONMILENARIO-", "CAZAESTELAR-", "SUPERDESTRUCTOR-", "YWING-", "XWING-" };
    static int indice;
    static int numero;
    static string [] Naves = new string[10];
    static int posicion = 0;    

  

    private static void Main(string[] args)
    {
        int opcion;

        System.Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");
        System.Console.WriteLine("1. Crear nueva nave");
        System.Console.WriteLine("2. Cambiar nombre de nave");
        System.Console.WriteLine("3. Listar todas las naves");
        System.Console.WriteLine("4. Eliminar una nave");
        System.Console.WriteLine("5. Eliminar todas las naves");
        System.Console.WriteLine("0. Salir");

        do
        {
            System.Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearNave();
                    break;

                case 2:
                    CambiarNombreNave();
                    break;

                case 3:
                    ListarNaves();
                    break;

                case 4:
                    ElimnarNave();
                    break;

                case 5:
                    ElimnarTodo();
                    break;
                
                case 6:
                    System.Console.WriteLine("Programa finalizado.");
                    opcion = 6;
                    break;
            

                default:
                    System.Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 6);
    }

    static void CrearNave()
    {
        Random Random = new Random();
        indice = Random.Next(0, nave.Length);
        numero = Random.Next(10, 99);
        string nuevaNave = nave[indice] + numero;
        Naves[posicion] = nuevaNave;
        posicion++;
        Console.WriteLine("✓ Nave creada: " + nave[indice] + numero);
        if (posicion >= Naves.Length)
        {
            Console.WriteLine("¡Capacidad máxima de naves alcanzada!");
        }
    }

    static void CambiarNombreNave()
    {
        System.Console.WriteLine("Ingrese el índice de la nave que desea renombrar:");
        int indiceNave = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Ingrese el nuevo nombre para la nave:");
        string nuevoNombre = Console.ReadLine();
        Console.WriteLine($"✓ Nave renombrada: {Naves[indiceNave]} -> {nuevoNombre}.");
        Naves[indiceNave] = nuevoNombre;

    }

    static void ListarNaves()
    //Listar todas las naves fabricadas: Mostrar un listado completo de todas las naves creadas, mostrando su índice y nombre.
    {
        System.Console.WriteLine("=== NAVES FABRICADAS ===");
       for (int i = 0; i < Naves.Length; i++)
        {
            if (Naves[i] != null)
            {
                Console.WriteLine($"[{i}]{Naves[i]}");
            }
        }
    }

    static void ElimnarNave()
    {
       System.Console.WriteLine("Ingrese el índice de la nave que desea eliminar:");
        int indiceNave = Convert.ToInt32(Console.ReadLine());
        Naves[indiceNave] = null;
        Console.WriteLine("✓ Nave eliminada correctamente.");

    }

    static void ElimnarTodo()
    {
        for (int i = 0; i < Naves.Length; i++)
        {
            Naves[i] = null;
        }
        Console.WriteLine("✓ Todas las naves han sido eliminadas.");
        posicion = 0;

    }

}