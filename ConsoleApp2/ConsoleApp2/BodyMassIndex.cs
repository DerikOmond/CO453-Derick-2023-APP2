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

        private string weightName;

        private double height;

        private double heightInCentimetres;
        private int heightInFeet;
        private int heightInInches;

        private string heightName;

        private double BMI;

        private double option1;
        private double option2;

        private bool correctOption1;
        private bool correctOption2;
        public void Run()
        {
            DisplayHeader();
            AskMeasurments();
            SetUnits();
            InputData();
            CalculateBMI();

            Console.WriteLine($"\nYour BMI: {BMI}");


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
            AskWeightUnit();
            UserOptions(HEIGHT);
            AskHeightUnit();

        }

        private void UserOptions(string measurement)
        {
            Console.WriteLine("\n-----------------------------------------------------------------------");
            if (measurement.Equals(WEIGHT))
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

        private void AskWeightUnit()
        {
            do
            {
                correctOption1 = false;
                Console.Write($"\nWhich unit of measurement would you like to use for your {WEIGHT}?\n> ");
                weight = Convert.ToInt16(Console.ReadLine());

                if(weight < 1 || weight >3) 
                {
                    Console.WriteLine("\n\nTHAT IS NOT AN OPTOIN!\nTRY AGAIN.\n");
                    correctOption1 |= true;
                }
            }
            while (correctOption1);
        }

        private void AskHeightUnit()
        {
            do
            {
                correctOption2 = false;
                Console.Write($"\nSelect the unit of measurement you would like to use for your {HEIGHT}\n> ");
                height = Convert.ToDouble(Console.ReadLine());

                if (height < 1 || height > 3)
                {
                    Console.WriteLine("THAT IS NOT AN OPTOIN!\nTRY AGAIN.");
                    correctOption2 |= true;
                }
            }
            while (correctOption2);
        }

        private void InputData()
        {
            Console.Write($"\nWhat is your weight in {weightName}?\n> ");
            double substitute = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\nWhat is your height in {heightName}?\n> ");
            Console.ReadLine();
        }
        
        private void CalculateBMI()
        {
            if (weight == 1 && height == 1)
            {
                weightName = KILOGRAMS;
                heightName = CENTIMETRES;
                BMI = weightInKilograms / Math.Pow((heightInCentimetres/100), 2);
            }
            else if (weight == 1 && height == 2)
            {
                weightName = KILOGRAMS;
                heightName = FEET;
                BMI = weightInKilograms / Math.Pow((heightInFeet * 0.3048), 2);
            }
            else if (weight == 1 && height == 3)
            {
                weightName = KILOGRAMS;
                heightName = INCHES;
                BMI = weightInKilograms / Math.Pow((heightInInches * 0.0254), 2);
            }
            else if (weight == 2 && height == 1)
            {
                weightName = POUNDS;
                heightName = CENTIMETRES;
                BMI = (weightInPounds * 0.453592) / Math.Pow((heightInCentimetres / 100), 2);
            }
            else if (weight == 2 && height == 2)
            {
                weightName = POUNDS;
                heightName = FEET;
                BMI = (weightInPounds * 0.453592) / Math.Pow((heightInFeet * 0.3048), 2);
            }
            else if (weight == 2 && height == 3)
            {
                weightName = POUNDS;
                heightName = INCHES;
                BMI = (weightInPounds * 0.453592) / Math.Pow((heightInInches * 0.0254), 2);
            }
            else if (weight == 3 && height == 1)
            {
                weightName = STONE;
                heightName = CENTIMETRES;
                BMI = (weightInStone * 6.35029) / Math.Pow((heightInCentimetres / 100), 2);
            }
            else if (weight == 3 && height == 2)
            {
                weightName = STONE;
                heightName = FEET;
                BMI = (weightInStone * 6.35029) / Math.Pow((heightInFeet * 0.3048), 2);
            }
            else if (weight == 3 && height == 3)
            {
                weightName = STONE;
                heightName = INCHES;
                BMI = (weightInStone * 6.35029) / Math.Pow((heightInInches * 0.0254), 2);
            }
        }

        private void SetUnits()
        {
            if (weight == 1 && height == 1)
            {
                weightName = KILOGRAMS;
                heightName = CENTIMETRES;
            }
            else if (weight == 1 && height == 2)
            {
                weightName = KILOGRAMS;
                heightName = FEET;
            }
            else if (weight == 1 && height == 3)
            {
                weightName = KILOGRAMS;
                heightName = INCHES;
            }
            else if (weight == 2 && height == 1)
            {
                weightName = POUNDS;
                heightName = CENTIMETRES;
            }
            else if (weight == 2 && height == 2)
            {
                weightName = POUNDS;
                heightName = FEET;
            }
            else if (weight == 2 && height == 3)
            {
                weightName = POUNDS;
                heightName = INCHES;
            }
            else if (weight == 3 && height == 1)
            {
                weightName = STONE;
                heightName = CENTIMETRES;
            }
            else if (weight == 3 && height == 2)
            {
                weightName = STONE;
                heightName = FEET;
            }
            else if (weight == 3 && height == 3)
            {
                weightName = STONE;
                heightName = INCHES;
            }
        }

    }
}
