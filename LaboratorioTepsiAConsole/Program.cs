using System;

namespace LaboratorioTepsiAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string res = "";
            Console.WriteLine("ins num dec");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int resto = num % 2;
                res = resto + res;
                num = num / 2;
            }
            Console.WriteLine($" risultato {res}");
        }
    }
}
