using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int numeroUno, numeroDos, total;
        Console.Write("Dame el primer numero: ");
        numeroUno = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dame el segundo numero: ");
        numeroDos = Convert.ToInt32(Console.ReadLine());
        total = numeroUno + numeroDos;
        Console.WriteLine("La suma de "+ numeroUno +" y "+ numeroDos +" da un total de "+ total);
    }
}