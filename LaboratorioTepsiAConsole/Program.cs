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
            Console.WriteLine("quale base vuoi? implementate fino a 16 ");
            int response = Convert.ToInt32(Console.ReadLine());
            int baseConv = response;


            while (num > 0)
            {
                int resto = num % baseConv;

                string alfa = "";
                switch (resto)
                {
                    case 10:
                        alfa = "A";
                        break;
                    case 11:
                        alfa = "B";
                        break;
                    case 12:
                        alfa = "C";
                        break;
                    case 13:
                        alfa = "D";
                        break;
                    case 14:
                        alfa = "E";
                        break;
                    case 15:
                        alfa = "F";
                        break;
                    default:
                        alfa = alfa + resto;
                        break;
                }
                res = alfa + res;
                num = num / baseConv;
            }

            Console.WriteLine($" la base che ho scelto è {baseConv}");
            Console.WriteLine($" risultato {res}");
            Console.WriteLine($" num attuale {num}");
        }
    }
}
