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
            //zadanie 8
            //Przećwiczenie pętli zagnieżdżonych i tablic 2D.
            int[,] matrix = { { 100, 20, 3 }, { 1000, 20000, 300000 }, { 1000000, 20000000, 300000000 } };
            int sumOfDiagonalMatrix = 0;
            int sumOfAntiDiagonalMatrix = 0;
            for (int i = 0; i < matrix.Length / 3; i++)
            {
                int antii = matrix.Length / 3 - 1 - i;
                sumOfDiagonalMatrix = sumOfDiagonalMatrix + matrix[i,i];
                sumOfAntiDiagonalMatrix = sumOfAntiDiagonalMatrix + matrix[i,antii];
            }
            Console.WriteLine($"Przekątna: {sumOfDiagonalMatrix}, anty-przekątna: {sumOfAntiDiagonalMatrix}");
            //zadanie 9
            //Implementacja jednego z najprostszych algorytmów sortowania.
            int[] zad9 = { 123, 83, 67, 228, 69 };
            int zad9cache = 0;
            int sortedValues = 0;
            Console.WriteLine("Tablica przed");
            Array.ForEach(zad9, Console.WriteLine);
            while(sortedValues != zad9.Length)
            for (int i = 0; i < zad9.Length - 1; i++)
            {
                if (sortedValues != zad9.Length)
                    {
                        if (zad9[i] > zad9[i + 1])
                        {
                            zad9cache = zad9[i + 1];
                            zad9[i + 1] = zad9[i];
                            zad9[i] = zad9cache;
                        }
                        else
                        sortedValues++;

                    }
                else
                break;
                    
                
            }
            Console.WriteLine("Tablica po");
            Array.ForEach(zad9, Console.WriteLine);
            //zadanie 10
            //Praca z dynamiczną strukturą danych i filtrowanie tablicy.
            int[] zad10 = { 123, 123, 67, 67, 69 };
            //duplicate counter
            int numberCounter = 0;
            for (int i = 0; i < zad10.Length - 1; i++)
            {
                for (int j = i + 1; j < zad10.Length - 1; j++)
                {
                    if (zad10[i] == zad10[j])
                    {
                        numberCounter++;
                    }
                        
                }
            }
            int[] zad10uniq = new int[zad10.Length - numberCounter];
            int index1 = 0;
            bool breaker = false;
            for (int i = 0; i < zad10.Length; i++)
            {
                for (int j = i + 1; j < zad10.Length - 1; j++)
                {
                    if (zad10[i] == zad10[j])
                    {
                        breaker = true;
                        break;
                    }
                }
                if (breaker == false)
                {
                    zad10uniq[index1] = zad10[i];
                    index1 = index1 + 1;
                }
                breaker = false;
            }
            Console.WriteLine("Tablica unikatowa");
            Array.ForEach(zad10uniq, Console.WriteLine);
            //zadanie 11
            //Zastosowanie algorytmu porównawczego do weryfikacji symetrii.
            int[] zad11 = [0, 12, 2, 5, 11, 9, 11, 5, 2, 12, 0];
            int halfZad11Length = zad7.Length / 2;
            bool isPalindrome = true;

            for (int i = 0; i < halfZad11Length; i++)
            {
                if (zad11[i] != zad11[zad11.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome == false)
            {
                Console.WriteLine("Nie jest palindromem");
            } else
            {
                Console.WriteLine("Jest palindromem");
            }
        }
    }
}
