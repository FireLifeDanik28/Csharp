namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            //Przećwiczenie pętli for i dostępu do elementów tablicy.
            int arrNumsWynik = 0;
            int[] arrNums = { 5, 10, 15, 20, 25 };
            for (int i = 0; i < arrNums.Length; i++) {
                arrNumsWynik = arrNumsWynik + arrNums[i];
            }
            Console.WriteLine(arrNumsWynik); //75
            //zadanie 2
            //Użycie pętli i instrukcji warunkowych if do przeszukiwania tablicy.
            int[] zad2arr = { 123, 83, 67, 228, 69 };
            int min = zad2arr[0];
            int max = zad2arr[0];
            for (int i = 1; i < zad2arr.Length; i++)
            {
                if (min > zad2arr[i])
                    min = zad2arr[i];

                if (max < zad2arr[i])
                    max = zad2arr[i];
            }
            Console.WriteLine($"min: {min}; max: {max}");//67 228
            //zadanie 3
            //Przećwiczenie manipulacji indeksem w pętli for.
            string[] imionaZad3Arr = { "Danylo", "George", "Osama", "Jan", "Paweł" };
            for (int i = 1; i < imionaZad3Arr.Length+1; i++)
            {
                Console.WriteLine(imionaZad3Arr[imionaZad3Arr.Length-i]);
            }
            //zadanie 4
            //Połączenie pętli foreach z operatorem modulo (%).
            int[] zad4arr = { 123, 83, 67, 228, 69 };
            int iloscPar = 0;
            foreach (int i in zad4arr)
            {
                if (i % 2 == 0)
                {
                    iloscPar++;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine($"Ilość liczb parzystych = {iloscPar}");

        }
    }
}
