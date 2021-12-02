using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENSIDHOM_Oussama_TP1_ST2TRD
{
    class EX3 : IEX
    {
        public void Run()
        {
            for (int i = -3; i < 4; i++)
            {
                try
                {
                    Console.WriteLine((10 / PowerFunction(i)));
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("You divide by 0");
                }
            }

        }

        public string DisplayExerciceNumber()
        {
            return "Exercice3";
        }
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }
    }
}
