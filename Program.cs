using System;
using System.Collections.Generic;

namespace SocialMediaFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfFriends = new List<string>();

            Console.WriteLine("Enter the names of your friends that liked your post.");
            var userInput = Console.ReadLine();

            while(!String.IsNullOrEmpty(userInput))
            {
                listOfFriends.Add(userInput);
                Console.WriteLine("Enter another name.");
                userInput = Console.ReadLine();
            }

            if(listOfFriends.Count == 1)
            {
                Console.WriteLine(listOfFriends[0]+" likes your post.");
            }
            else if(listOfFriends.Count == 2)
            {
                Console.WriteLine(listOfFriends[0] + " and "+ listOfFriends[1] + " like your post.");
            }
            else if(listOfFriends.Count > 2)
            {
                Console.WriteLine(listOfFriends[0] + ", " + listOfFriends[1] + " and " + (listOfFriends.Count-2) +" others like your post.");
            }
            else
            {
                return;
            }

        }
    }
}
