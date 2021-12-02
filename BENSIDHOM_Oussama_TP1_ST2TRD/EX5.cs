using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENSIDHOM_Oussama_TP1_ST2TRD
{
    class EX5 : IEX
    {
        Random rnd = new Random();
        public void Run()
        {
            int size = AskUserForParameter();
            try
            {
                Console.WriteLine("Please write 1 if you would like a decorated tree or 0 for a simple tree :");
                int t = Convert.ToInt32(Console.ReadLine());
                if (t == 0)
                {
                    for (int i = 1; i < size + 1; i++)
                    {
                        Console.WriteLine(new string(' ', size - i) + new string('*', 2 * i - 1) + new string(' ', size - i));
                    }
                    Console.WriteLine(new string(' ', size - 2) + "| |");
                }
                else if (t == 1)
                {
                    int deco_i;
                    int deco_o;
                    for (int i = 1; i < size + 1; i++)
                    {
                        deco_i = rnd.Next(2, i + 1);
                        deco_o = rnd.Next(i + 1, 2 * i);
                        Console.Write(new string(' ', size - i));
                        for (int j = 1; j < 2 * i; j++)
                        {
                            if (j % deco_i == 0)
                            {
                                Console.Write("i");
                            }
                            else if (j % deco_o == 0)
                            {
                                Console.Write("o");
                            }
                            else
                            {
                                Console.Write('*');
                            }
                        }
                        Console.WriteLine(new string(' ', size - i));
                    }
                    Console.WriteLine(new string(' ', size - 2) + "| |");
                }
                else
                {
                    Console.WriteLine("Your choice is not good");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public string DisplayExerciceNumber()
        {
            return "Exercice5";
        }

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please enter the size of the tree :");
            int.TryParse(Console.ReadLine(), out var result);
            while ((result > 21)^(result<3))
            {
                Console.WriteLine("Please enter the size of the tree :");
                int.TryParse(Console.ReadLine(), out result);
            }
            
            return result;
        }
    }
}
