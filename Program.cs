using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    #region Error message function
    public static class Error
    {
        public static void ErorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\a\n\t{message}\n\a");
            Console.ResetColor();
        }
    }
    #endregion

    #region prime factor finding function
    public static class Prime
    {
        public static void PrimeFactors(int number)
        {
            var list = new List<int>();
            Console.Write($"\n  {number} sayısının asal çarpanları :");
            int i = 2;
            while (number > 1)
            {
                if (number % i == 0)
                {
                    number /= i;
                    if (!list.Contains(i))
                        list.Add(i);
                }
                else i++;
            }
            list.ForEach(item => Console.Write($"{item,3}"));
            Console.WriteLine();

        }
        public static void SumOf(int number)
        {
            var list = new List<int>();
            Console.Write($"\n  {number} sayısının asal çarpanları toplamı :");
            int total = 0;
            int i = 2;
            while (number > 1)
            {
                if (number % i == 0)
                {
                    number /= i;
                    if (!list.Contains(i))
                        list.Add(i);
                }
                else i++;
            }
            list.ForEach(item => total += Convert.ToInt32(item.ToString()));
             Console.WriteLine(total);
        }
        public static void ProductOf(int number)
        {
            var list = new List<int>();
            Console.Write($"\n  {number} sayısının asal çarpanları çarpımı :");
            int total = 1;
            int i = 2;
            while (number > 1)
            {
                if (number % i == 0)
                {
                    number /= i;
                    if (!list.Contains(i))
                        list.Add(i);
                }
                else i++;
            }
            list.ForEach(item => total *= Convert.ToInt32(item.ToString()));
            Console.WriteLine(total);
        }


    }
    #endregion

    #region Finding the smallest of the common multiple and the greatest of the common divisors of two numbers
    public static class OkekObeb
    {
        public static int Okek(int x,int y)
        {
            int result = 1;
            
            while (x !=1 && y != 1)
            {
                int count = 2;
                for (int i = 1; i <= (x>y ? x : y); i++)
                {
                    if (x % count == 0 || y % count == 0)
                    {
                        result *= count;
                        if (x % count == 0)
                            x /= count;
                        if (y % count == 0)
                            y /= count;
                    }
                    else count++;
                }
            }
            return result;
        }
        public static int Obeb(int x, int y)
        {
            int result = 1;

            while (x != 1 && y != 1)
            {
                int count = 2;
                for (int i = 2; i <= (x > y ? x : y); i++)
                {
                    if (x % count == 0 || y % count == 0)
                    {
                        if (x % count == 0 && y % count == 0)
                            result *= count;
                        if (x % count == 0)
                            x /= count;
                        if (y % count == 0)
                            y /= count;
                    }
                    else count++;
                }
            }
            return result;
        }

    }
    #endregion

    #region computing the factorial of a number
    public static class Faktorial
    {
        public static int Calculate(int number) {
            if (number == 1 || number == 0)  return 1; 
            return number*Calculate(number-1);      
        }       
    }
    #endregion

    #region Sequentially adding string numbers with ',' among them to an array as an element
    public static class StringToNumber
    {
        public static void Turn(string number) {
            string[] spliteArray = number.Split(',');
            int count = spliteArray.Length;
            int[] numberArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                numberArray[i] = Convert.ToInt32(spliteArray[i]);
                Console.WriteLine($"Dizi[{i+1}] = {numberArray[i]}");
            }

        }
    }
    #endregion

    #region Converting binary number to decimal or decimal to binary number function
    public static class BinaryToDecimal
    {
        public static void Decimal(int decimalNumber)
        {  
            int Decimal = decimalNumber;
            bool control = true;
            string binaryNumber="";
            string result = "";
            if (Decimal == 1)
                Console.WriteLine($"   {Decimal} decimal = (1) binary");
            if (Decimal == 0)
                Console.WriteLine($"   {Decimal} decimal = (0) binary");
            while (control)
            {
                if (!(Decimal + 1 >= 0)) 
                { 
                    Error.ErorMessage("Negatif sayılar binary sayılara çevrilemez!");
                    control = false;
                    break;
                }
                if (!(Decimal == 1 || Decimal == 0))
                {
                    binaryNumber += Decimal % 2;
                    Decimal /= 2;
                    if (Decimal == 1) { binaryNumber += 1; control = false;  }
                        
                    if (Decimal == 0) { binaryNumber += 0; control = false;  }           
                }
            }

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
                result += (binaryNumber[i] - '0');
            Console.Write($"  {decimalNumber} decimal = ({result}) binary");
        }
        public static void Binary(string Binary)
        {
            int length = Binary.Length;
            int[] steps = new int[length];
            int decimalNumber = 0;
            bool control = true;
            for (int i = 0; i < length; i++)
            {
                if (!(Binary[i] == '0' || Binary[i] == '1'))
                {
                    Error.ErorMessage("Hatalı Giriş! Binary sayı giriniz...");
                    control = false;
                    break;
                }
                steps[i] = (Binary[i] - '0');
            }
            if (control)
            {
                for (int i = 0; i < length; i++)
                decimalNumber += (int)Math.Pow(2, length - (1 + i)) * steps[i];
                Console.WriteLine($" ({Binary}) binary  = {decimalNumber} decimal");                    
            }
            
        }
    }
    #endregion

    # region function for counting vowels in a sentence or word
    public static class CharCount
    {
        public static void Vowel(string word) {
            string Word = word.ToLower();
            int count = 0;
            for (int i = 0; i <Word.Length; i++)

            {
                if (Word[i]=='a'|| Word[i] == 'e' || Word[i] == 'ı' || Word[i] == 'i' ||
                    Word[i] == 'u' || Word[i] == 'ü' || Word[i] == 'o' || Word[i] == 'ö')
                {
                    count++;
                }
            }
            Console.WriteLine($" {word} kelimesinde {count} tane sesli harf var.");
        }
    }
    #endregion

    class Program {
        public static void Main(string[] args)
        {
         
        }
    }
}
