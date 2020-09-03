using System;

namespace Exo_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo_1 - Division, modulo, division entière sur deux entiers

            //int nb1, nb2;
            //nb1 = 5;
            //nb2 = 2;
            //Console.WriteLine($"Division entière : {nb1/nb2} - Modulo : {nb1%nb2} - Division : {(double)nb1/nb2}");

            #endregion

            #region Exo_2 - Vérification du BBAN

            Console.WriteLine("Veuillez introduire votre BBAN:");
            string bban = Console.ReadLine();
            if (ulong.TryParse(bban, out _) && bban.Length == 12)
            {
                ulong tenFirst = ulong.Parse(bban.Substring(0, 10));            //tenFirst = bban / 100 => Division entière
                ushort twoLast = ushort.Parse(bban.Substring(10,2));            //twoLast = bban % 100 => Reste inférieur à 100
                if ((tenFirst%97 == twoLast)||(tenFirst%97==0 && twoLast == 97))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("KO");
                }

            }
            else {
                Console.WriteLine("Votre BBAN n'est pas valide.");
            }

            #endregion
        }
    }
}
