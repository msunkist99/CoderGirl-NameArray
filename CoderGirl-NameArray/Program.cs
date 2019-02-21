using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderGirl_NameArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "NameArray";

            //  remember - the first member of the array and list has an index of 0
            //  this is called 'zero based'
            //  indexes for our full array and list will be 0 through 29

            //  for an ARRAY you must declare the entry count or load the array during initialization
            //  index will be 0 - 29
            string[] namesArray = new string[30];

            //  for a LIST you do not have to declare the entry count, it will grow as you added to the LIST
            List<string> namesList = new List<string>();

            string name;
            int arrayLimit = 0;

            // FOR THIS LOGIC THE ASSUMPTION IS THAT AT LEASE ONE NAME IS ENTERED
            Console.WriteLine("You must enter at lease one name");
            // gather the names entered by the user into the names ARRAY and names LIST
            // NOTE:  the user may enter less than 30 names
            for (int i = 0; i < 30; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter a name  - ");
                }
                else
                {
                    Console.Write("Enter a name or press enter to stop - ");
                }

                name = Console.ReadLine();

                if (name == "")
                {
                    // user pressed enter so name is blank
                    // setting i equal to a value of 30 will break us out of this For loop

                    // you could also use break;
                    i = 30;
                    //break;
                }
                else
                {
                    // capture the name value entered by the user into the ARRAY
                    namesArray[i] = name;
                    //  I am capturing the length of the array in arrayLimit
                    //  because namesArray.Length will always be 30
                    //  user may not enter all 30 names
                    arrayLimit = i;

                    // capture the name value entered by the user into the LIST
                    namesList.Add(name);
                }
            }

            Console.WriteLine();

            // Note that you cannot use namesArray.Count() to display the number of names entered into your array
            // because you declared the Array as having 30 entries. 
            // namesArray.Count() would return a value of 30        
            Console.WriteLine($"You entered {arrayLimit + 1} names to the ARRAY.");
            Console.WriteLine($"You entered {namesList.Count()} Names to the LIST");
            Console.WriteLine();

            // generate a random number between 0 and the arrayIndex (inclusive)
            // this radom number will be used to 'pick' the lucky name in your ARRAY and LIST

            // create an instance of the Random class - called random
            Random random = new Random();

            // use the random instance to generate a random number
            // randomNameIndex will be a number between 0 and the value of arrayLimit - inclusive
            int randomNameIndex = random.Next(0, arrayLimit);

            // the following commented line of code would also generate your random number
            // int randomNameIndex = random.next(0, (namesList.Count() - 1));

            Console.WriteLine("The random name from the array is " + namesArray[randomNameIndex]);
            Console.WriteLine("The random name from the list is  " + namesList[randomNameIndex]);
            Console.WriteLine();

            // iterate through the ARRAY - skipping the lucky name
            // NOTE:  you cannot 'remove' an entry in an ARRAY
            Console.WriteLine("The other names from the ARRAY are - ");
            for (int i = 0; i <= arrayLimit; i++)
            {
                if (i != randomNameIndex)
                {
                    Console.WriteLine(namesArray[i]);
                }
            }
            Console.WriteLine();

            // remove the lucky name from the LIST
            namesList.RemoveAt(randomNameIndex);
            Console.WriteLine("The other names from the LIST are - ");

            // iterate through the LIST - you removed the lucky name from the list
            foreach (var listName in namesList)
            {
                Console.WriteLine(listName);
            }
            Console.ReadLine();

        }
    }
}