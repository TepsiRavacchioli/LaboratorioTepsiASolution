using System;

namespace LaboratorioTepsiAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string result = "";
            string numIns, baseIns = "";
            int baseConv = 0;
            /*CONTROLLO NUMERO INTERO*/
            do
            {
                Console.WriteLine("Inserisci un numero decimale da convertire INTERO");
                numIns = Console.ReadLine();
            } while (!Int32.TryParse(numIns, out num));


            /*CONTROLLO BASE INSERITA*/

            do
            {
                Console.WriteLine("In quale base vuoi convertire? ammessi interi da 2 fino a 16 ");
                do
                {
                    Console.WriteLine("La base deve essere un intero ");
                    baseIns = Console.ReadLine();
                } while (!Int32.TryParse(baseIns, out baseConv));

            } while (baseConv < 2 || baseConv > 16);

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
                result = alfa + result;
                num = num / baseConv;
            }

            Console.WriteLine($"il risultato che ottengo dalla conversione di {numIns}");
            Console.WriteLine($" in base {baseConv} è: {result}");
            Console.ReadLine();

        }
    }
}
