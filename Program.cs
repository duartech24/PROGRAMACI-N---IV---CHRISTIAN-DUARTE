internal class Program
{
    //Verificar si un numero es positivo
    //o negativo
    private static void Main(string[] args)
    {
        //Entradas
        Console.WriteLine("===NUMEROS POSITIVOS Y NEGRATIVOS");
        int num;
        Console.Write("Dame un numero entero: ");
        num=Convert.ToInt32(Console.ReadLine());
        //Procesos
        //Salidas
        if (num == 0)
        {
            Console.WriteLine("Es un número POSITIVO");
        }
        else
        {
            Console.WriteLine("Es un numero NEGATIVO");
        }
    }
}