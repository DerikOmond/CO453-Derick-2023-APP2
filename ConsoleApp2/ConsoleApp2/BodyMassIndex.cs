/// <summary>
/// This application calculates a user's body mass index (BMI) by using their height and weight.
/// If they require further assistance or are seeking something else, they are redirected to the
/// NHS website.
/// </summary>
/// <author>
/// Derick Omondi version 1.0
/// </author>

//Dependancies
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp2
{
    //BMI class
    public class BodyMassIndex
    {
        //String constants refering to weight.
        private const string WEIGHT = "WIGHT";
        private const string KILOGRAMS = "kilograms";
        private const string POUNDS = "pounds";
        private const string STONE = "stone";

        //String constants refering to height.
        private const string HEIGHT = "HEIGHT";
        private const string CENTIMETRES = "centimetres";
        private const string FEET = "feet";
        private const string INCHES = "inches";

        //User decided metric for their weight.
        private double weight;

        //Value and unit for the users weight.
        private double weightValue;
        private string weightName;
        
        //User decided metric for their height.
        private double height;

        //Value and unit for the users height.
        private double heightValue;
        private string heightName;

        ///Final calculated BMI.
        private double BMI;

        //Limit for the options the user can input.
        private bool correctOption1;
        private bool correctOption2;

        //Decideds whether the user will loop through the program again.
        private bool repeat;

        //Single public method which objects access the class
        public void Run()
        {
            do
            {
                DisplayHeader();
                AskMeasurments();
                SetUnits();
                InputData();
                CalculateBMI();
                OutputBMI();
                DisplayRange();
                TryAgain();
            }
            while (repeat = true);
            
        }

        //Displays the header to the user in the terminal
        //Gives title and autor name
        private void DisplayHeader()
        {
            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("========                           App02 BMI Calculator                           ========");
            Console.WriteLine("========                             By Derick Omondi                             ========");
            Console.WriteLine("==========================================================================================\n");
            Console.Write("Press enter to begin > ");
            Console.ReadLine();
        }

        //Brings together the process of asking for the user's measurements (height and weight).
        private void AskMeasurments()
        {
            UserOptions(WEIGHT);
            AskWeightUnit();
            UserOptions(HEIGHT);
            AskHeightUnit();

        }

        //Determines which options will be displayed to the user.
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

        //Asks and figures out when the user has input an option within the diplayed options for weight.
        private void AskWeightUnit()
        {
            do
            {
                correctOption1 = false;
                Console.Write($"\nWhich unit of measurement would you like to use for your {WEIGHT}?\n> ");
                weight = Convert.ToInt16(Console.ReadLine());

                if (weight < 1 || weight > 3)
                {
                    Console.WriteLine("\n\nTHAT IS NOT AN OPTOIN!\nTRY AGAIN.\n");
                    correctOption1 |= true;
                }
            }
            while (correctOption1);
        }

        //Asks and figures out when the user has input an otption within the displayed options for height.
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

        //Asks for the user to input their measurements.
        private void InputData()
        {
            Console.Write($"\nWhat is your weight in {weightName}?\n> ");
            weightValue = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\nWhat is your height in {heightName}?\n> ");
            heightValue = Convert.ToDouble(Console.ReadLine());
        }

        //BMI is calculated according to the units provided.
        private void CalculateBMI()
        {
            if (weight == 1 && height == 1)
            {
                BMI = weightValue / Math.Pow((heightValue / 100), 2);
            }
            else if (weight == 1 && height == 2)
            {
                BMI = weightValue / Math.Pow((heightValue * 0.3048), 2);
            }
            else if (weight == 1 && height == 3)
            {
                BMI = weightValue / Math.Pow((heightValue * 0.0254), 2);
            }
            else if (weight == 2 && height == 1)
            {
                BMI = (weightValue * 0.453592) / Math.Pow((heightValue / 100), 2);
            }
            else if (weight == 2 && height == 2)
            {
                BMI = (weightValue * 0.453592) / Math.Pow((heightValue * 0.3048), 2);
            }
            else if (weight == 2 && height == 3)
            {
                BMI = (weightValue * 0.453592) / Math.Pow((heightValue * 0.0254), 2);
            }
            else if (weight == 3 && height == 1)
            {
                BMI = (weightValue * 6.35029) / Math.Pow((heightValue / 100), 2);
            }
            else if (weight == 3 && height == 2)
            {
                BMI = (weightValue * 6.35029) / Math.Pow((heightValue * 0.3048), 2);
            }
            else if (weight == 3 && height == 3)
            {
                BMI = (weightValue * 6.35029) / Math.Pow((heightValue * 0.0254), 2);
            }
        }

        //According to the units the user had specified, the unit names will be adjusted.
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


        //Output BMI
        private void OutputBMI()
        {
            Console.WriteLine($"\nBMI: {BMI}\n");
            DisplayResult();
        }

        //Tells the user which bracket (underweight, healthy, overweight or obese) they are in.
        private void DisplayResult()
        {
            if (BMI <= 0)
            {
                Console.WriteLine("Error... You don't exit :/\n");
            }
            else if (BMI < 18.5)
            {
                Console.WriteLine("You are in the underweight range.\n");
            }
            else if (18.5 <= BMI && BMI < 24.9) 
            {
                Console.WriteLine("You are in the healthy wight range.\n");
            }
            else if (24.9 <= BMI && BMI < 29.9)
            {
                Console.WriteLine("You are in the overweight range.\n");
            }
            else if (30 < BMI)
            {
                Console.WriteLine("You are in the obese range.\n");
            }
        }

        //Givers extra information on the topic
        private void DisplayRange()
        {
            Console.WriteLine("A healthy BMI ranges from 18.5 - 24.9 for" +
                " the average height of a 5 foot 9 inches man or the average" +
                " 5 foot and 4 inch woman. Above or below this could be " +
                "considered as underweight or overweight.");

            BAMEMessage();
            ChildrenMessaeg();

            Console.Write("Enter 'y' to find out more on the NHS website\n>");
            string answer = Console.ReadLine();

            if ((answer.ToLower()).Equals("y"))
            {
                NHSRedirect();
            }
        }

        //Message regarding BAME individuals
        private void BAMEMessage()
        {
            Console.WriteLine("\nIndividuals of BAME backgrounds often have a lower" +
                " cut off point due to a difference in physical structure and body fat" +
                " was seen to be distributed slightly differently.\n");
        }

        //Message for children's BMI
        private void ChildrenMessaeg()
        {
            Console.WriteLine("For children, BMI is centile specific. Due to weight and" +
                " height changing with age including their physical fitness ranging amongst" +
                " children and teenagers.\n");
        }

        //Opens a new tab in the primary search engine to the NHS website
        private void NHSRedirect()
        {
            var url = "https://www.nhs.uk/common-health-questions/lifestyle/what-is-the-body-mass-index-bmi/";
            var process = new System.Diagnostics.ProcessStartInfo();
            process.UseShellExecute = true;
            process.FileName = url;
            System.Diagnostics.Process.Start(process);

            Console.WriteLine("\n\nCheck Your primary bowser");
        }

        //Asks the user if they want to repeat the program
        private void TryAgain()
        {
            Console.Write("\nEnter 'y' if you would like to try again.\n> ");
            string decision = Console.ReadLine();

            if((decision.ToLower()).Equals('y'))
            {
                this.repeat = true;
            }
        }
    }
}