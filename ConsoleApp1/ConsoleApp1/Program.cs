using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets users input
            Console.WriteLine("Please enter expected grade in ISM 4300 ");

            //Use try catch to validtae users input and handle an error
            try
            {
                //This variable will gather the user input
                string input = Console.ReadLine();

                //Converts string to interger
                int grade = int.Parse(input);

                //If statement to test user's input to grades on syllabus
                if ((grade <= 100) && (grade >= 98))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an A+!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 97) && (grade >= 92))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an A!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 91) && (grade >= 90))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an A-!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 89) && (grade >= 88))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an B+!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 87) && (grade >= 82))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an B!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 81) && (grade >= 80))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an B-!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 79) && (grade >= 78))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an C+!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 77) && (grade >= 72))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an C!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 71) && (grade >= 70))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an C-!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 69) && (grade >= 68))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an D+!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 67) && (grade >= 62))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an D!");
                }

                //Else if statement to test all the other ossible inputs
                else if ((grade <= 61) && (grade >= 60))
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an D-!");
                }

                //Else if statement to test all the other ossible inputs
                else if (grade < 60)
                {
                    //Displays the projected grade based on input
                    Console.WriteLine("Your projected grade for ISM 4300 is an F!");
                }
            } //end of try

            //If there is an error the catch will let the user know
            catch
            {
                Console.WriteLine("Please insert an interger value, such as 84.");
            }
        }
    }
}
