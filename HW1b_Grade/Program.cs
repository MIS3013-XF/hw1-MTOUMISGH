// HW1b Grade

// Your Name: Matthew Tran
// Did you seek help ? If yes, specify the helper or web link here: Visited Office Hours for Github help.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname; //strings that stay strings
            string lname;
            string stuid;

            double ex1; //needs next var set to get a value
            double ex2;
            double ex3;
            double hw;
            double clpar;

            string ex1Str; //takes input from user to be converted later
            string ex2Str;
            string ex3Str;
            string hwStr;
            string clparStr;

            Console.WriteLine("Type your first name:"); //takes inputs from user
            fname = Console.ReadLine();
            Console.WriteLine("Type your last name:");
            lname = Console.ReadLine();
            Console.WriteLine("Type your student id:");
            stuid = Console.ReadLine();

            Console.WriteLine("List your Exam 1 grade.");
            ex1Str = Console.ReadLine();
            ex1 = Convert.ToDouble(ex1Str);

            Console.WriteLine("List your Exam 2 grade.");
            ex2Str = Console.ReadLine();
            ex2 = Convert.ToDouble(ex2Str);

            Console.WriteLine("List your Exam 3 grade.");
            ex3Str = Console.ReadLine();
            ex3 = Convert.ToDouble(ex3Str);

            Console.WriteLine("List your overall grade for the Homework section of the class.");
            hwStr = Console.ReadLine();
            hw = Convert.ToDouble(hwStr);

            Console.WriteLine("List your overall grade for the Class Participation section of the class.");
            clparStr = Console.ReadLine();
            clpar = Convert.ToDouble(clparStr);

            double ex1Weight = ex1 * 0.15; //takes input values from prompts and multiplies them by the syllabus weight (Fall2025)
            double ex2Weight = ex2 * 0.25;
            double ex3Weight = ex3 * 0.25;
            double hwWeight = hw * 0.20;
            double clparWeight = clpar * 0.15;
            double sum = (ex1Weight + ex2Weight + ex3Weight + hwWeight + clparWeight)/100; //adds weighted portions to get final grade, turns into % form

            Console.WriteLine($"{lname}, {fname} (ID:{stuid}), your final grade is: {sum.ToString("P2")}");
            Console.ReadKey();
        }
    }
}
