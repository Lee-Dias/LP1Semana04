using System;
using System.ComponentModel.DataAnnotations;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static int GetSpecial( int n){
            int p = 0;
            int u = 1;
            int t = 0;
            for(int k = 0; k <= n; k++){
              t = u + 2*p;
              p= u;
              u = t;
            }
            return t;
        }

    }
}
