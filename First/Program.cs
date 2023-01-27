using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Verilmish n ededinin 3 ve 7-ye bolunub-bolunmemesi

            //Console.WriteLine("Ededi daxil edin:");
            //string aStr = Console.ReadLine();
            //int a = Convert.ToInt32(aStr);

            //if (a % 3 == 0 && a % 7 == 0)
            //{
            //    Console.WriteLine("Bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("Bolunmur");
            //}

            #endregion

            #region Verilmish n ve m ededi cutdurse, ceminin hesablanmasi

            //Console.WriteLine("n ededini daxil edin:");
            //string nStr = Console.ReadLine();
            //int n = Convert.ToInt32(nStr);

            //Console.WriteLine("m ededini daxil edin:");
            //string mStr = Console.ReadLine();
            //int m = Convert.ToInt32(mStr);

            //int sum = 0;

            //if (n % 2 == 0 && m % 2 == 0)
            //{
            //    sum = n + m;
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine("Her ikisi ve ya biri cut deyil");
            //}

            #endregion

            #region Verilmish n ve m ededleri arasindaki tek ededlerin sayinin while ile tapilmasi

            //Console.WriteLine("Baslangic ededi daxil edin:");
            //string nStr = Console.ReadLine();
            //int n = Convert.ToInt32(nStr);

            //Console.WriteLine("Bitme ededi daxil edin:");
            //string mStr = Console.ReadLine();
            //int m = Convert.ToInt32(mStr);

            //int count = 0;

            //int i = n;

            //while (i < m)
            //{
            //    if (i % 2 != 0)
            //    {
            //        count++;
            //    }

            //    i++;
            //}
            //Console.WriteLine(count);

            #endregion

            #region Verilmish array'deki cut ededlerin ceminin for ile tapilmasi

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        sum += numbers[i];
            //    }
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Verilmish array'deki ededlerin icerisinden murekkeb ededlerin ceminin for ile tapilmasi

            int[] numbers = { 2, 55, 84, 6, 8, 54 };

            int sum = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                for (int i = 2; i < numbers[index]; i++)
                {
                    if (numbers[index] % i == 0)
                    {
                        sum += numbers[index];
                        break;
                    }
                }
            }

            Console.WriteLine(sum);

            #endregion
        }
    }
}
