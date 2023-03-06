using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BodyMassIndex
    {
        public void Run()
        {
            DisplayHeader();
            AskMeasurments();

            Console.ReadLine();
        }

        private void DisplayHeader()
        {
            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("========                           App02 BMI Calculator                           ========");
            Console.WriteLine("========                             By Derick Omondi                             ========");
            Console.WriteLine("==========================================================================================\n");
            Console.Write("Press enter to begin > ");
            Console.ReadLine();
        }

        private void AskMeasurments()
        {
            AskWeight();
            AskHeight();

        }

        private void AskWeight()
        {
            Console.Write("\nWhat is your current weight?\n>");
            Console.ReadLine();
        }

        private void AskHeight()
        {
            Console.Write("\nWhat is your current height\n>");
            Console.ReadLine();
        }
    }
}
