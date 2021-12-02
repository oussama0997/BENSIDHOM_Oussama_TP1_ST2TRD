using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENSIDHOM_Oussama_TP1_ST2TRD
{
    class EX4 : IEX
    {
        public void Run()
        {
            rectangle();
        }

        public string DisplayExerciceNumber()
        {
            return "Exercice4";
        }

        private static void rectangle()

        {

            int[] param = AskUserForParameter();
            int ligne = param[1];
            int colonne = param[0];
            int l;
            int c;

            if ((colonne == 1) & (ligne == 1))
            {
                Console.WriteLine("0");
            }
            else if ((ligne == 1) & (colonne > 1))
            {
                Console.WriteLine("0" + new string('-', colonne - 2) + "0");
            }
            else if ((colonne == 1) & (ligne > 1))
            {
                Console.WriteLine("0");
                for (int i = 2; i < ligne; i++)
                {
                    Console.WriteLine("|");
                }
                Console.WriteLine("0");

            }
            else
            {
                {
                    try
                    {
                        l = 0;
                        c = 0;
                        Console.WriteLine("0" + new string('-', colonne - 2) + "0");
                        for (int i = 2; i < ligne; i++)
                        {
                            Console.Write("|");
                            for (int j = 2; j < colonne; j++)
                            {
                                if (c % 3 == 0)
                                {
                                    Console.Write("*");
                                    c = c + 1;
                                }
                                else
                                {
                                    Console.Write(" ");
                                    c = c + 1;
                                }

                            }
                            Console.WriteLine("|");
                            l = l + 1;
                            c = l * 2;
                            if (c % 3 == 0)
                            {
                                c = 0;
                            }
                        }
                        Console.WriteLine("0" + new string('-', colonne - 2) + "0");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }


        }
        private static int[] AskUserForParameter()
        {
            int[] result = new int[2];
            Console.WriteLine("Please write two numbers n and m separated by a ',' and press enter :");
            string choice = Console.ReadLine();
            try
            {
                int.TryParse(choice.Split(',')[0], out int first);
                int.TryParse(choice.Split(',')[1], out int second);
                result[0] = first;
                result[1] = second;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}
