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
            //zadanie 5
            //Praca z dwiema tablicami jednocześnie.
            int[] a5 = { 123, 83, 67, 228, 69 };
            int[] b5 = new int[5];
            for (int i = 0; i < a5.Length; i++)
            {
                b5[i] = a5[i] * 2;
            }
            Console.WriteLine("Array a");
            Array.ForEach(a5, Console.WriteLine);
            Console.WriteLine("Array b");
            Array.ForEach(b5, Console.WriteLine);
            //zadanie 6
            //Interakcja z użytkownikiem i przeszukiwanie tablicy.
            int[] zad6 = { 123, 83, 67, 228, 69 };
            bool isFound = false;
            Console.WriteLine("Tablica z zadania 6");
            Array.ForEach(zad6, Console.WriteLine);
            Console.WriteLine("Proszę podać liczbę by znaleść z tablicy");
            int liczba = int.Parse(Console.ReadLine());
            for (int i = 0; i < zad6.Length; i++)
            {
                int maxAmt = zad6.Length - 1;
                if (liczba == zad6[i])
                {
                    //jest
                    Console.WriteLine($"Liczba {liczba} znajduje się w tablicy na indeksie {i}.");
                    isFound = true;
                    break;
                }
                if (isFound == false && i == maxAmt)
                Console.WriteLine($"Liczba {liczba} nie została znaleziona w tablicy.");
            }
            //zadanie 7
            //Zrozumienie algorytmu zamiany elementów bez tworzenia nowej tablicy.
            int[] zad7 = { 123, 83, 67, 228, 69 };
            int cache1;
            int cache2;
            int halfZad7Length = zad7.Length / 2;
            Console.WriteLine("Tablica przed");
            Array.ForEach(zad7, Console.WriteLine);

            for (int i = 0; i < halfZad7Length; i++)
            {
                cache1 = zad7[i];
                cache2 = zad7[zad7.Length - 1 - i];
                zad7[zad7.Length - 1 - i] = cache1;
                zad7[i] = cache2;
            }

            Console.WriteLine("Tablica po");
            Array.ForEach(zad7, Console.WriteLine);

        }
    }
}
