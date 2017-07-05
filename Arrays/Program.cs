using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Declaring without initializing
            //int[] myFirstArray;

            //// Declaring and initalizing my second array
            //string[] myStringArray = { "Frist", "second", "third", "fourth" };

            //// Declarig and initialing a char array with the letter of your last name
            //char[] lastName = { 'P', 'H', 'A', 'M' };

            //// I want my consol to print three elements of my array (HAM)
            //Console.WriteLine(lastName[1]);
            //Console.WriteLine(lastName[2]);
            //Console.WriteLine(lastName[3]);

            //// Create the followings arrays and print using the correct index numbers:
            //// Arrays of Top 10  Vaction spots
            //// Print the first and last name vaction spots
            //// Arrays of ages of 3 childern know
            //// Prints each child's age
            //// Arrays of GPA on a 4.0 scale of 8 students - you don't have to print
            //// Array of the First letter of a 4 of your classmate's names who are sitting near you
            //// Print all four on the same line


            //string[] myVaction= { "San Deigo", "Miami", "Banff", "LA", "Ibiza", "Maine", "Florida", "St. Thomas", "Austin", "Colorado", };
            //Console.WriteLine(myVaction[0]);
            //Console.WriteLine(myVaction[9]);

            //int[] childrensAge = { 3, 5, 8 };
            //Console.WriteLine(childrensAge[0]);
            //Console.WriteLine(childrensAge[1]);
            //Console.WriteLine(childrensAge[2]);


            //char[] classmatesName = { 'V', 'P', 'N', 'M', }; // Console.WriteLine(classmatesName); // <- Print on the same line; only works with CHAR 
            //Console.WriteLine(classmatesName);
            //Console.Write(classmatesName[0]);
            //Console.Write(classmatesName[1]);
            //Console.Write(classmatesName[2]);
            //Console.Write(classmatesName[3]);

            //// Console.WriteLine("\n{0}, {1}, {2}, {3}", classmatesName[0], classmatesName[1], classmatesName[2], classmatesName[4]);


            // dateType[] nameOfArray = new dataType[#ofElements]; <-- Creating a new array 
            int[] numberOfSeats = new int[21];
            string[] studentsInClass = new string[21];

            // nameOfArray[index] = Elements;
            studentsInClass[0] = "Jordan";

            Console.WriteLine("Please enter in the name of the next student");
            studentsInClass[1] = Console.ReadLine();
            Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            Console.WriteLine("Please enter the age of the person in the first seat.");
            //Create a new int array with 21 spots and a call it ageOfStudentsInClass
            int[] ageOfStudentsInClass = new int[21];

            // Assign the value of the int at the 0 index of ageOfStudentsInClass to.....
            //... the user's input coverted into an int
            ageOfStudentsInClass[0] = int.Parse(Console.ReadLine()); // int.Parse turns the string into an int <-- Console.ReadLine reads int as a string so we use int.Parse
            Console.WriteLine("The age of the first student in the first seat is " + ageOfStudentsInClass[0]);

            // Create a new string variable and set it equal to the int at the index of 0
            // and convert it into a string
            string firstIndex = ageOfStudentsInClass[0].ToString(); 
            









        }
    }
}
