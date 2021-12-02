using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENSIDHOM_Oussama_TP1_ST2TRD
{
    class EX2 : IEX
    {
        public void Run()
        {
            Prime();
            Fibo();
            Fact();
        }

        public string DisplayExerciceNumber()
        {
            return "Exercice2";
        }

        private static void Prime()
        {
            int nbr_div;
            Console.WriteLine("Prime numbers");
            for (int i = 1; i < 1001; i++)
            {
                nbr_div = 0;
                for (int j = 1; j < Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        nbr_div++;
                    }
                }
                if (nbr_div == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static void Fibo()
        {
            Console.WriteLine("Enter a number to calculate its Fibo:");
            int nbr = Convert.ToInt32(Console.ReadLine());
            if ((nbr == 1) ^ (nbr == 0))
            {
                Console.WriteLine("Fibonacci(" + nbr + ") = 1");
            }

            else
            {
                int F_n_1 = 1;
                int F_n_2 = 1;
                int F = 0;
                for (int i = 2; i < nbr; i++)
                {
                    F = F_n_1 + F_n_2;
                    F_n_2 = F_n_1;
                    F_n_1 = F;
                }
                Console.WriteLine("Fibonacci(" + nbr + ") = " + F);
            }

        }

        private static void Fact()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int nbr = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            for (int i = 2; i < nbr + 1; i++)
            {
                p = p * i;
            }
            Console.WriteLine(nbr + "! = " + p);
        }
    }
}
