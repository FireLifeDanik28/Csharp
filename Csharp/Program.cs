namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            int arrNumsWynik = 0;
            int[] arrNums = { 5, 10, 15, 20, 25 };
            for (int i = 0; i < arrNums.Length; i++) {
                arrNumsWynik = arrNumsWynik + arrNums[i];
            }
            Console.WriteLine(arrNumsWynik); //75
        }
    }
}
