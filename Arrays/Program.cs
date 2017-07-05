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
            // Declaring without initializing
            int[] myFirstArray;

            // Declaring and initalizing my second array
            string[] myStringArray = { "Frist", "second", "third", "fourth" };

            // Declarig and initialing a char array with the letter of your last name
            char[] lastName = { 'P', 'H', 'A', 'M' };

            // I want my consol to print three elements of my array (HAM)
            Console.WriteLine(lastName[1]);
            Console.WriteLine(lastName[2]);
            Console.WriteLine(lastName[3]);

            // Create the followings arrays and print using the correct index numbers:
            // Arrays of Top 10  Vaction spots
            // Print the first and last name vaction spots
            // Arrays of ages of 3 childern know
            // Prints each child's age
            // Arrays of GPA on a 4.0 scale of 8 students - you don't have to print
            // Array of the First letter of a 4 of your classmate's names who are sitting near you
            // Print all four on the same line

          
            string[] myVaction= { "San Deigo", "Miami", "Banff", "LA", "Ibiza", "Maine", "Florida", "St. Thomas", "Austin", "Colorado", };
            Console.WriteLine(myVaction[0]);
            Console.WriteLine(myVaction[9]);

            int[] childrensAge = { 3, 5, 8 };
            Console.WriteLine(childrensAge[0]);
            Console.WriteLine(childrensAge[1]);
            Console.WriteLine(childrensAge[2]);


            char[] classmatesName = { 'V', 'P', 'N', 'M', }; // Console.WriteLine(classmatesName); // <- Print on the same line; only works with CHAR 
            //Console.WriteLine(classmatesName);
            //Console.Write(classmatesName[0]);
            //Console.Write(classmatesName[1]);
            //Console.Write(classmatesName[2]);
            //Console.Write(classmatesName[3]);

            Console.WriteLine("\n{0}, {1}, {2}, {3}", classmatesName[0], classmatesName[1], classmatesName[2], classmatesName[4]);









        }
    }
}
