using Tyuiu.TishkinaEA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.TishkinaEA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма эллементов массива = " + DataService.AdditionArray(arraynums));
            
            Console.WriteLine("Разность эллементов массива = " + DataService.SubstractionArray(arraynums));
            
            Console.WriteLine("Произведение эллементов массива = " + DataService.MultiplicationArray(arraynums));
            
            Console.ReadKey();
        }
    }
}
