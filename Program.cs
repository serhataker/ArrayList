using System;
using System.Collections.Generic;
using System.Numerics;
namespace Arratlist
{
    public class array
    {
        static void Main(string[] args)
        {


            int[] array = new int[10]; // Question 1 we created the array with 10 member

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = i * i; // We assign the value of arrays mmeber
            }
            foreach (int i in array)
            {

                Console.WriteLine($"Member Values {i}");//print the members of array
            }

            int[] array2 = new int[11]; // we created temp array list with 11 members 

            for (int i = 0; i < array.Length; i++)
            {

                array2[i] = array[i]; // we assign the all array list send to the array2 
            }

            Console.WriteLine("Please enter the eleven index of the array"); // we want to the user 11. members
            string newValue = Console.ReadLine();

            if (int.TryParse(newValue, out int newnNumber)) // we controled and replaceing int value
            {

                array2[array.Length] = newnNumber; // we assign 11. member
            }

            else
            {

                array2[array.Length] = 0; // if it is not int value we send to default value
            }



            Array.Sort(array2); // we sorted Arrays sorting method 

            foreach (var item in array2)
            {
                Console.WriteLine(item);// printed and sorting end of members array 


            }
        }




    }
}
