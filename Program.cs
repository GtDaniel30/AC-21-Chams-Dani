internal class Program
{

    private static void Main(string[] args)
    {
        System.Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");
        ElimnarNave();
        ElimnarTodo();
    }

    static void CrearNave()
    {
        string[] nave = { "HALCONMILENARIO-", "CAZAESTELAR-", "SUPERDESTRUCTOR-", "YWING-", "XWING-", };
        Random random = new Random();
        int indice = random.Next(0, nave.Length);
        int numero = random.Next(10, 100);
        Console.WriteLine("Nave seleccionada: " + nave[indice] + numero);
    }

    static void ElimnarNave()
    {

        string[] nave = { "HALCONMILENARIO-", "CAZAESTELAR-", "SUPERDESTRUCTOR-", "YWING-", "XWING-", };
        Console.WriteLine("Ingrese la posicion de la nave a eliminar:");
        int posicion = Convert.ToInt32(Console.ReadLine());
        nave[posicion] = null;
        Console.WriteLine($"Nave {posicion} es  eliminada.");

    }


    static void ElimnarTodo()
    {

        string[] nave = { "HALCONMILENARIO-", "CAZAESTELAR-", "SUPERDESTRUCTOR-", "YWING-", "XWING-", };
        nave = null;
        Console.WriteLine("Todas las naves han sido eliminadas.");

    }
}