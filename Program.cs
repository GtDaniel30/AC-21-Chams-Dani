internal class Program
{

    private static void Main(string[] args)
    {
        System.Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");

    }

    static void CrearNave()
    {
        string[] nave = { "HALCONMILENARIO-", "CAZAESTELAR-", "SUPERDESTRUCTOR-", "YWING-", "XWING-", };
        Random random = new Random();
        int indice = random.Next(0, nave.Length);
        int numero = random.Next(10, 100);
        Console.WriteLine("Nave seleccionada: " + nave[indice] + numero);
    }
}