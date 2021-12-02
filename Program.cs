//import users class
using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

var dog = new Animal("dog",12, "bark");

dog.Speak();
dog.Voice= "woof";
dog.Speak();
var dog2= new Dog("dog2",78, "bark");
dog2.Speak();

var cat = new Animal("cat",12, "meaw");
cat.Speak();
cat.Voice= "meaow";
cat.Speak();

            //users class 
            Users user = new Users("jenny kibiri");
user.Age=25;
Console.WriteLine(user.Name);
Console.WriteLine(user.Age);

            user.Add();




            //convert string to int
            int age = 0;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());




            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote! is your age" + " " + age);
            }
            else
            {
                Console.WriteLine("You are not old enough to vote!");
            }




            Console.WriteLine("Hello World!");
            //Array
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            Console.WriteLine(array[2]);
            //example 2
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array2[2]);

            //List
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list[1]);
            //list 2
            List<string> list2 = new List<string>();
            list2.Add("Hello");
            list2.Add("World");
            list2.Remove("Hello");
            List<string> listOfOranges = new List<String>();
            listOfOranges.Add("orange");
            listOfOranges.Add("orange");
            listOfOranges.Add("orange");
            Console.WriteLine(list2[0]);

            //Dictionary and dict is a like an object in JS 
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("one", 1);
            dictionary.Add("two", 2);
            dictionary.Add("three", 3);


            Dictionary<int, String> users = new Dictionary<int, String>();
            users.Add(1, "lee");
            users.Add(2, "jenny");
            users.Add(3, "james");
            Console.WriteLine(users[2]);

            if (users.ContainsKey(2))
            {
                Console.WriteLine("yes");


            }



        }
    }
}

//variables
//arrays
//loops
//objects


//conditions
//functions
//classes
