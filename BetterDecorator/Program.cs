using System;

namespace BetterDecorator
{
    /// <summary>
    /// Este programa recebe 3 valores uma string um char e um int 
    /// o programa devolve a char atras e a frente da string consante o numero 
    /// no int
    /// </summary>
    class Program
    {
        /// <summary>
        /// converte os argumentos recebidos de string para char e para int
        /// e chaam o decor
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char o = char.Parse(args[1]);
            
            int a = int.Parse(args[2]);


            Console.WriteLine(Decor(args[0],o,a));
        }
        /// <summary>
        /// faz dois if's para colocar uma quantidade de char
        /// recebido atras e a frente da string consoante a quantidade no int 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="i"></param>
        /// <returns></returns>
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
