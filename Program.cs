using System;
using System.Collections.Generic;


namespace DZ_4_Class
{
    class Program
    {
        static void Main()
        {
            try
            {

                var s = new Stack("один", "два", "три", "четыре", "восемь", "сто");

                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                var deleted = s.Pop();

                Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");

                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                s.Pop();
                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                s.Pop();
                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                s.Pop();
                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                s.Pop();
                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                s.Pop();
                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                s.Pop();

                Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
                s.Pop();
                Console.WriteLine();
                Console.WriteLine("________________");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Стек пустой");
            }
           
            var s1 = new Stack("один", "два", "три");
                var s2 = new Stack("6", "5", "4");
                s1.Merge(s2);
                Console.WriteLine("в стеке s1 теперь элементы -");
                while (s1.Size > 0)
                {
                    string item = s1.Bop();
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
                Console.WriteLine("________________");

                var s3 = new Stack("a", "b", "c");
                s3.Merge(new Stack("один", "два", "три"));

                Console.WriteLine("в стеке s3 теперь элементы -");
                while (s3.Size > 0)
                {
                    string item = s3.Bop();
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
                Console.WriteLine("________________");
            
            }
            }
         }
    

            

    
   









