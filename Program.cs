internal class Program
{

    private static void Main(string[] args)
    {
        int opcion;


        System.Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");
        System.Console.WriteLine("1. Crear nueva nave");
        System.Console.WriteLine("2. Cambiar nombre de nave");
        System.Console.WriteLine("3. Listar todas las naves");
        System.Console.WriteLine("4. Eliminar una nave");
        System.Console.WriteLine("5. Elimiar todas las naves");
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
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                default:
                    System.Console.WriteLine("Numero no válido");
                    break;
            }

        } while (opcion != 0);
    }

    static void CrearNave()
    {
        string[] nave = { "HALCONMILENARIO-", "CAZAESTELAR-", "SUPERDESTRUCTOR-", "YWING-", "XWING-", };
        Random random = new Random();
        int indice = random.Next(0, nave.Length);
        int numero = random.Next(10, 100);
        System.Console.WriteLine("");
        Console.WriteLine("✓ Nave creada: " + nave[indice] + numero);
        System.Console.WriteLine("");

    }
}