using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            char o = char.Parse(args[1]);
            
            int a = int.Parse(args[2]);


            Console.WriteLine(Decor(args[0],o,a));
        }

        private static string Decor(string s, char dec, int i)
        {
            string a = "";
            string b = "";
            for (int k = 0; k < i; k++){
                    a = a +dec; 
                
            }
            for (int k = 0; k < i; k++){
                    b = b+dec; 
            }
                
            return $"{a} {s} {b}";     
        }
        
    }
}
