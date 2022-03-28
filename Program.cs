using System;

namespace classwork28032022
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");


            // try
            // {
            //     int v = 3;
            //     Console.WriteLine(int.Parse(Console.ReadLine()));
            //      Console.WriteLine(v/0);
            // }
            // catch(DivideByZeroException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            //  catch(FormatException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }

            // Console.WriteLine("Segun");




            int x;
            var y =  false;
            do
            {
                y = int.TryParse(Console.ReadLine(), out x);
                
                
            }while(!y);
            Console.WriteLine(x);

             try
            {
                int v = 3;
                Console.WriteLine(int.Parse(Console.ReadLine()));
                 Console.WriteLine(v/0);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
             catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Segun");


        }
    }
}
