using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BodyMassIndex
    {
        private const string WEIGHT = "WIGHT";
        private const string KILOGRAMS = "kilograms";
        private const string POUNDS = "pounds";
        private const string STONE = "stone";

        private const string HEIGHT = "HEIGHT";
        private const string CENTIMETRES = "centimetres";
        private const string FEET = "feet";
        private const string INCHES = "inches";

        private double weight;

        private double weightInKilograms;
        private int weightInPounds;
        private int weightInStone;

        private double height;

        private double heightInCentimetres;
        private int heightInFeet;
        private int heightInInches;

        private double BMI;

        private bool correctOption1;
        private bool correctOption2;
        public void Run()
        {
            DisplayHeader();
            AskMeasurments();
            CalculateBMI();


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
            UserOptions(WEIGHT);
            AskWeight();
            UserOptions(HEIGHT);
            AskHeight();

        }

        private void UserOptions(string measurement)
        {
            if(measurement.Equals(WEIGHT))
            {
                Console.WriteLine($"\n1. {KILOGRAMS}");
                Console.WriteLine($"2. {POUNDS}");
                Console.WriteLine($"3. {STONE}\n");
            }
            else if (measurement.Equals(HEIGHT))
            {
                Console.WriteLine($"\n1. {CENTIMETRES}");
                Console.WriteLine($"2. {FEET}");
                Console.WriteLine($"3. {INCHES}\n");
            }

        }

        private void AskWeight()
        {
            do
            {
                correctOption1 = false;
                Console.Write("\nWhich unit of measurement would you like to use?\n> ");
                weight = Convert.ToInt16(Console.ReadLine());

                if(weight < 1 || weight >3) 
                {
                    Console.WriteLine("\nTHAT IS NOT AN OPTOIN!\nTRY AGAIN.\n");
                    correctOption1 |= true;
                }
            }
            while (correctOption1);
        }

        private void AskHeight()
        {
            do
            {
                Console.Write("\nWhat is your current height in centimetres\n> ");
                height = Convert.ToDouble(Console.ReadLine());

                if (height < 1 || height > 3)
                {
                    Console.WriteLine("THAT IS NOT AN OPTOIN!\nTRY AGAIN.");
                    correctOption2 |= true;
                }
            }
            while (correctOption2);
        }

        private void CalculateBMI()
        {
            if (weight == 1 && height == 1)
            {
                BMI = weightInKilograms / Math.Pow((heightInCentimetres/100), 2);
            }
            else if (weight == 1 && height == 2)
            {
                BMI = weightInKilograms / Math.Pow((heightInFeet * 0.3048), 2);
            }
            else if (weight == 1 && height == 3)
            {
                BMI = weightInKilograms / Math.Pow((heightInInches * 0.0254), 2);
            }
            else if (weight == 2 && height == 1)
            {
                BMI = (weightInPounds * 0.453592) / Math.Pow((heightInCentimetres / 100), 2);
            }
            else if (weight == 2 && height == 2)
            {
                BMI = (weightInPounds * 0.453592) / Math.Pow((heightInFeet * 0.3048), 2);
            }
            else if (weight == 2 && height == 3)
            {
                BMI = (weightInPounds * 0.453592) / Math.Pow((heightInInches * 0.0254), 2);
            }
            else if (weight == 3 && height == 1)
            {
                BMI = (weightInStone * 6.35029) / Math.Pow((heightInCentimetres / 100), 2);
            }
            else if (weight == 3 && height == 2)
            {
                BMI = (weightInStone * 6.35029) / Math.Pow((heightInFeet * 0.3048), 2);
            }
            else if (weight == 3 && height == 3)
            {
                BMI = (weightInStone * 6.35029) / Math.Pow((heightInInches * 0.0254), 2);
            }
        }

    }
}
