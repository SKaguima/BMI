﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user choose between Pounds and Kilograms

            string myFormula;
            string weightLbs;
            string weightKgs;
            string heightIn;
            string heightM;


            Console.WriteLine("Press 1 for Pounds and 2 for Kilograms");
               myFormula = Console.ReadLine();
                      

            if (myFormula == "1")
            {               
                Console.WriteLine("Your BMI will be calculated in pounds and Inches");
                {
                   Console.WriteLine("Enter your Weight");                
                   weightLbs = Console.ReadLine();
                }

                
                    Console.WriteLine("Enter your Height");                   
                    heightIn = Console.ReadLine();
                

                double myWeightLbs = Convert.ToDouble(weightLbs);
                double myHeightIn = Convert.ToDouble(heightIn);

                {
                    var bmiPounds = (myWeightLbs * 703) / (myHeightIn * myHeightIn);
                    Console.WriteLine("Your BMI is: " + bmiPounds.ToString());
                    
                    {


                        if (bmiPounds >= 30)
                        {
                            Console.WriteLine("You are Obese");
                            Console.ReadLine();
                        }

                        else if (bmiPounds > 25)
                        {
                            Console.WriteLine("You are Overweight");
                            Console.ReadLine();
                        }

                        else if (bmiPounds > 18.5)
                        {
                            Console.WriteLine("You are Normal");
                            Console.ReadLine();
                        }

                        else if (bmiPounds < 18.5)
                        {
                            Console.WriteLine("You are Underweight");
                            Console.ReadLine();
                        }
                    }
                }

            }

            if (myFormula == "2")
            {
                Console.WriteLine("Your BMI will be calculated in Kilograms and Meters");
                {
                    Console.WriteLine("Enter your Weight");
                    weightKgs = Console.ReadLine();
                }


                Console.WriteLine("Enter your Height");
                heightM = Console.ReadLine();


                double myWeightKgs = Convert.ToDouble(weightKgs);
                double myHeightM = Convert.ToDouble(heightM);

                {
                    var bmiKgs = (myWeightKgs) / (myHeightM * myHeightM);
                    Console.WriteLine("Your BMI is: " + bmiKgs.ToString());

                    {
                        if (bmiKgs >= 30)
                        {
                            Console.WriteLine("You are Obese");
                            Console.ReadLine();
                        }
                        else if (bmiKgs > 25)
                        {
                            Console.WriteLine("You are Overweight");
                            Console.ReadLine();
                        }

                        else if (bmiKgs > 18.5)
                        {
                            Console.WriteLine("You are Normal");
                            Console.ReadLine();
                        }

                        else if (bmiKgs < 18.5)
                        {
                            Console.WriteLine("You are Underweight");
                            Console.ReadLine();
                        }
                    }

                }
            }
        }
    }
}
