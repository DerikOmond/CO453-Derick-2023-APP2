using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BodyMassIndex
    {
        private double wight;

        private double wightInKilograms;
        private int weightInPounds;
        private int weightInStone;

        private string kilograms = "kilograms";
        private string pounds = "pounds";
        private string stone = "stone";

        private double height;

        private double heightInCentimetres;
        private int heightInFeet;
        private int heightInInches;

        private string centimetres = "centimetres";
        private string feet = "feet";
        private string inches = "inches";

        private double BMI;
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
            Console.Write("\nWhat is your current weight in kilograms?\n> ");
            wight = Convert.ToDouble(Console.ReadLine());
        }

        private void AskHeight()
        {
            Console.Write("\nWhat is your current height in centimetres\n> ");
            height = Convert.ToDouble(Console.ReadLine());
        }


    }
}
