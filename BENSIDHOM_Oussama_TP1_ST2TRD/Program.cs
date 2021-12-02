using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENSIDHOM_Oussama_TP1_ST2TRD
{
    class Program
    {
        private static EX1 Exercice1;
        private static EX2 Exercice2;
        private static EX3 Exercice3;
        private static EX4 Exercice4;
        private static EX5 Exercice5;
        static void Main(string[] args)
        {
            InitExample();
            Console.WriteLine(Exercice1.DisplayExerciceNumber());
            Exercice1.Run();

            Console.WriteLine(Exercice2.DisplayExerciceNumber());
            Exercice2.Run();

            Console.WriteLine(Exercice3.DisplayExerciceNumber());
            Exercice3.Run();

            Console.WriteLine(Exercice4.DisplayExerciceNumber());
            Exercice4.Run();

            Console.WriteLine(Exercice5.DisplayExerciceNumber());
            Exercice5.Run();
            Console.ReadKey();
        }
        private static void InitExample()
        {
            Exercice1 = new EX1();
            Exercice2 = new EX2();
            Exercice3 = new EX3();
            Exercice4 = new EX4();
            Exercice5 = new EX5();
        }
    }
}
