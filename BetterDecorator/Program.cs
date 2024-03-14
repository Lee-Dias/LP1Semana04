﻿using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decor( "Good Morning ! " , '∗' ));
            Console.WriteLine(Decor( "Good E v e ni n g ! " , '.' ) );

        }

        private static string Decor(string s, char dec)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";     
        }
        
    }
}
