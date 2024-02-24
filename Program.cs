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

                var s = new Stack("один", "два", "три");

                s.GetContents("s");
                
                Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");

                var deleted = s.Pop();

                Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");

                while (s.Size >= 0)
                {
                    Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
                    s.Pop();
                }

                Console.WriteLine();

                Console.WriteLine("--------------------");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Стек пустой");
            }

            Console.WriteLine("--------------------");

            Console.WriteLine("метод расширения Merge:");

            var s1 = new Stack("a", "b", "c");

            s1.GetContents("s1");
            
            s1.Merge(new Stack("1", "2", "3"));
            
            s1.GetContents("s1");
            
            Console.WriteLine("--------------------");
            
            Console.WriteLine("метод Concat:");

            var s5 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));

            s5.GetContents("s");
          
            Console.WriteLine("--------------------");
        }
    }
}
    

            

    
   









