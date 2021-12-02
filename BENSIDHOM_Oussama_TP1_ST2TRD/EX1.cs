using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENSIDHOM_Oussama_TP1_ST2TRD
{
    class EX1 : IEX
    {
        public void Run()
        {
            Multiplication_Table();
            Odd_result();
            User_input();
        }

        public string DisplayExerciceNumber()
        {
            return "Exercice1";
        }

        // Fct 1
        private static void Multiplication_Table()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Multiplication Table of " + i);
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }

        // Fct 2
        private static void Odd_result()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Odd result of multiplication Table of " + i);
                }

                for (int j = 1; j < 11; j++)
                {
                    if ((i * j) % 2 == 1)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                }
            }

        }

        // Fct 2
        private static void User_input()
        {
            Console.WriteLine("Enter a number:");
            int nbr = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {nbr} = {i * nbr}");
            }


        }

    }
}
