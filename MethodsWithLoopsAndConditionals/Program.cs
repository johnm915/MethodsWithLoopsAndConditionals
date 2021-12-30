using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            Threes();
        }
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Threes()
        {

            for (int x =3; x <=999; x += 3)
            {
                Console.WriteLine(x);
            }
        } 
        
        
            
            
            
            

        



    }
}       