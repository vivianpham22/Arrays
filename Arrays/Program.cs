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


            //// datetype[] nameofarray = new datatype[#ofelements]; <-- creating a new array 
            //int[] numberofseats = new int[21];
            //string[] studentsinclass = new string[21];

            //// nameofarray[index] = elements;
            //studentsinclass[0] = "jordan";

            //console.writeline("please enter in the name of the next student");
            //studentsinclass[1] = console.readline();
            //console.writeline("the student in the second seat is {0}.", studentsinclass[1]);

            //console.writeline("please enter the age of the person in the first seat.");
            //// create a new int array with 21 spots and a call it ageofstudentsinclass
            //int[] ageofstudentsinclass = new int[21];

            ////assign the value of the int at the 0 index of ageofstudentsinclass to.....
            ////... the user's input coverted into an int
            //ageofstudentsinclass[0] = int.parse(console.readline()); // int.parse turns the string into an int <-- console.readline reads int as a string so we use int.parse
            //console.writeline("the age of the first student in the first seat is " + ageofstudentsinclass[0]);

            ////create a new string variable and set it equal to the int at the index of 0
            //// and convert it into a string
            //string firstindex = ageofstudentsinclass[0].tostring();



            //string[] restaurntsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(restaurntsInMall.Length);

            ////For review
            ////Declare and not initilize
            //int[] myIntArrayAgain;

            ////Declare an array when I DO know the elements
            //char[] lettersInFirstName = { 'V', 'i', 'v', 'i', 'a', 'n' };

            ////Declare and intitialize an array when i DONT know the element
            //string[] variableName = new string[42];


            //// To practice using .Length create a char array of the letters in your middle name
            //// ... and print the numbero f char's to the Console.
            //char[] lettersInMiddleName = { 'H', 'o', 'n', 'g' };
            //Console.WriteLine(lettersInMiddleName.Length);

            ////Declare and initialize a string array 
            ////Using the Length property, print the SECOND TO LAST element in the array
            //string[] toSix = { "One", "Two", "Three", "Four", "Five", "Six", };
            //// int numToSix = toSix.Length;
            //Console.WriteLine(toSix[toSix.Length - 2]);
            //                 //  toSix  [ 6 - 2 ]
            //                 //  toSix   =  [ 4 ]


            //// IndexOf is a METHOD used to search an array for a specificed value and returns
            //// the index postion of the FIRST matching value found
            //int[] bestYearEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearEver, 1985)); // ()) <-- used for METHOD

            //// LastIndexOf is a method used to search an array for a specified value and returns
            //// the index positon of the LAST matching value found 
            // Console.WriteLine(Array.LastIndexOf(bestYearEver, 1985));


            // // Reverse Method 
            // int[] palindromeNumber = { 1, 2, 3, 4, 5, 6, 7 };
            // Console.WriteLine(palindromeNumber[0]);
            //// Console.WriteLine(palindromeNumber[2]);
            // Array.Reverse(palindromeNumber);
            // Console.WriteLine(palindromeNumber[0]);
            // // Console.WriteLine(palindromeNumber[2]);


            // Sort
            // Will sort numbers in an array from the lowest to highest
            // Will sort char's and strings in alphabetical order from A-Z

            //string[] powerRangers = { "Green", "Yellow", "Pink", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            //string[] daysInWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            //Console.WriteLine(daysInWeek.Length);


            // Declare and initialize a string array of first names.  
            // Choose a name to find and print the IndexOf
            //string[] firstNames = { "Vivian", "Alicia", "Justin", "Quinn", "Ryan", "Vincent" };
            //Console.WriteLine(Array.IndexOf(firstNames, "Alicia"));

            //Create an array of lucky numbers. Each number should repeat at least once. 
            //Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 6, 8, 16, 22, 31, 6, 8, 16, 22, 31 };





            // Create an array of alphabet characters. 
            // Print the first index of the array.
            // Now reverse the array and print the first index.
            char[] alphabetABC = { 'a', 'v', 'j', 'q', 'r', 'g' };




            ////Create an array of student names in random order. 
            ////Order the students’ names using the sort method.
            ////Print the first and last students’ names.
            //string[] studentsName = { "Alicia", "Javier", "Tommy", "Anthony", "Sam" };
            //Console.WriteLine(studentsName[0]);
            //Array.Sort(studentsName);
            //Console.WriteLine(studentsName[3]); // <-- Will print in alphabetical orders ABC


            // Ask 10 people for their favorite numbers and create an array of those numbers.
            // Order the numbers using the sort method.
            // Print the first and last numbers.
























        }
    }
}
