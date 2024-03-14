using System;
using System.ComponentModel.DataAnnotations;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of the special sequence: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(i));
        }
        private static int GetSpecial( int n){
            int p = 0;
            int u = 1;
            int t = 0;
            if (n == 1){
                t = 1;
            }
            for(int k = 2; k <= n; k++){
              t = u + 2*p;
              p= u;
              u = t;
            }
            return t;
        }

    }
}
