using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> favoriteFoods = new List<string>() {"pizza", "steak", "chicken", "broccoli", "potatoes" };
            //Console.WriteLine(favoriteFoods[0]); //this shows pizza
            //Console.WriteLine(favoriteFoods[4]); //this shows potatoes

            //List<string> badFoods = new List<string>();
            //badFoods[0] = ("Onions");
            //badFoods[1] = ("Liver");
            //badFoods[2] = ("Mushrooms");
            //badFoods[3] = ("Pig feet");


            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(13);
            //luckyNumbers.Add(7);
            //luckyNumbers.Add(23);
            //luckyNumbers.Add(44);

            List<string> favoriteMovies = new List<string>() { "Superbad", "Wolf of Walstreet", "Masters of the Universe" };
            //for (int counter = 0; counter < favoriteMovies.Count; counter++)
            //{
            //    Console.WriteLine(favoriteMovies[counter]);
            //} //prints out the favorite movies list line by line

            //foreach (string film in favoriteMovies)
            //{
            //    Console.WriteLine(film);
            //}  //same as above

            //favoriteMovies.Remove("Superbad");
            //favoriteMovies.Remove("Wolf of Walstreet");

            //foreach (string movie in favoriteMovies)
            //{
            //    Console.WriteLine(movie);
            //}  //the above two remove lines removes items from the list.  the cw is printing what's left


            //List<string> favoriteAnimals = new List<string>();
            //favoriteAnimals.Add("Gorillas");
            //favoriteAnimals.Add("Lion");
            //favoriteAnimals.Add("Bears");
            //favoriteAnimals.Add("Dogs");
            //favoriteAnimals.Add("Cheetah");
            //for (int animals = 0; animals < favoriteAnimals.Count; animals++)
            //{
            //    Console.WriteLine(favoriteAnimals[animals]);
            //}

            //List<bool> boolList = new List<bool>() { true, false, false, true, false };
            //for (int counter = 0; counter < boolList.Count; counter++)
            //{
            //    if (boolList[counter] == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No need for an umbrella today, enjoy the sun");
            //    }
            //}

            List<int> numberList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));
            //numberList.Remove((27));
            //numberList.Remove((77));
            //numberList.Remove((32));
            //numberList.Remove((6));
            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));
            numberList.RemoveAt(0);
            for (int number = 0; number < numberList.Count; number++)
            {
                Console.WriteLine(numberList[number]);
            }
            numberList.Insert(0, 20);
            for (int number = 0; number < numberList.Count; number++)
            {
                Console.WriteLine(numberList[number]);
            }



        }


}
}
