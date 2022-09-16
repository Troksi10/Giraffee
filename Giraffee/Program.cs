using System;

namespace Giraffee
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Shapes

            //Console.WriteLine("   /|");
            //Console.WriteLine("  / |");
            //Console.WriteLine(" /  |");
            //Console.WriteLine("/___|");

            #endregion

            #region Variables



            //string characterName = "Tom";
            //int characterAge;
            //characterAge = 25;

            //Console.WriteLine("There once was a man named " + characterName);
            //Console.WriteLine("He was" + characterAge+ " years old");

            //characterName = "Mike";
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didn't like being " + characterAge);

            #endregion

            #region DataTypes

            //string phrase = "Giraffe Academy";
            //char grade = '$';
            //int age = 30;
            //double gpa = 3.2;
            //bool isMale = true;

            // Console.WriteLine(false);

            #endregion

            #region workingWithStrings

            //string phrase = "Giraffe Academy";
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.ToLower());
            //Console.WriteLine(phrase.Contains("Academy"));
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase[2]);
            //Console.WriteLine(phrase.IndexOf("Academy"));
            //Console.WriteLine(phrase.Substring(8));
            //Console.WriteLine(phrase.Substring(8,3));

            #endregion

            #region workingWithNumbers

            //Console.WriteLine( 5 + 8);
            //Console.WriteLine(5 - 8);
            //Console.WriteLine(5 % 2);
            //Console.WriteLine(4 + 2 * 3);
            //Console.WriteLine((4 + 2) * 3);
            //Console.WriteLine(5 + 8.1);
            //Console.WriteLine(5 / 2);
            //Console.WriteLine(5 / 2.0);

            //int num = 6;
            //Console.WriteLine(num);
            //num++;
            //Console.WriteLine(num);
            //num--;
            //Console.WriteLine(num);

            //Console.WriteLine(Math.Abs(-40));
            //Console.WriteLine(Math.Pow(3, 2));
            //Console.WriteLine(Math.Sqrt(36));
            //Console.WriteLine(Math.Max(4, 90));
            //Console.WriteLine(Math.Round(4.3));
            //Console.WriteLine(Math.Round(4.6));

            #endregion

            #region GettingUserInput

            //Console.Write("Enter your name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            //Console.Write("Enter your Age : ");
            //string age = Console.ReadLine();
            //Console.Write($"Hello {name}.You are {age} old.");

            #endregion

            #region Calculator

            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num  +  6);

            //Console.Write("Enter a number : ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter a second number : ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);

            //Console.Write("Enter a number : ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a second number : ");
            //int num4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num3 + num4);

            #endregion

            #region MadLibsGame

            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color : ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun : ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity : ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine($"Roses are {color}");
            //Console.WriteLine($" {pluralNoun} are blue");
            //Console.WriteLine($"I Love {celebrity}");



            #endregion

            #region Arrays

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //string[] friends = new string[5];
            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //luckyNumbers[1] = 900;

            //Console.WriteLine(luckyNumbers[1]);

            #endregion

            #region If

            //bool isMale = false;
            //bool isTall = false;



            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall Male");

            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short Male");
            //}else if(!isMale && isTall)
            //{
            //    Console.WriteLine("You are not a Male but you are tall");
            //}else
            //{
            //    Console.WriteLine("You are not the both");
            //}


            #endregion

            #region BetterCalculator

            //Console.WriteLine("Enter a number");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter a second number");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator ");
            //string op = Console.ReadLine();

            //if (op == "+")
            //{
            //    Console.Write(num1 + num2);
            //}else if (op == "-")
            //{
            //    Console.Write(num1 - num2);
            //}else if( op == "*")
            //{
            //    Console.Write(num1 * num2);
            //}
            //else
            //{
            //    Console.WriteLine("invalid Operator");
            //}

            #endregion

            #region WhileLoop

            //int index = 1;

            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 5);


            #endregion

            #region Building a Geussing Game

            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool OutOfGuesses = false;

            //while (guess != secretWord && !OutOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter guess : ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        OutOfGuesses = true;
            //    }
            //}

            //if (OutOfGuesses)
            //{
            //    Console.Write("You Lose");
            //}
            //else
            //{
            //    Console.WriteLine("You Win !");

            //}
            #endregion

            #region ForLoop
            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}
            #endregion

            #region Building an Exponent Method

            //Console.WriteLine(GetPow(4,3));

            #endregion

            #region 2d Arrays

            //int[,] numberGrid =
            //{
            //    { 1,2},
            //    { 3,4},
            //    {5,6}
            //};

            //Console.WriteLine(numberGrid[2,1]);

            #endregion

            #region Exception Handling

            //try
            //{
            //    Console.Write("Enter a number : ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter a second number : ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{

            //}

            #endregion

            #region Classes & Objects

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            Book book3 = new Book();

            Console.WriteLine(book2.Title);

            #endregion

            #region Objects Methods

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());


            #endregion

            #region Getters & Setters / Static class

            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            //Movie shrek = new Movie("Shrek","Adam Adamson","PG");

            //Song holiday = new Song("Holiday", "Green Day", 200);
            //Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            //Console.WriteLine(Song.songCount);
            //Console.WriteLine(kashmir.getSongCount());
            #endregion

            #region Static Methods and Classes

            //Console.WriteLine(Math.Sqrt(144));

            //UsefulTool.SayHi("Mike");

            #endregion

            #region Inheritance

            Chef chef = new Chef();
            chef.MakeChicken();

            Italian_Chef italianchef = new Italian_Chef();
            italianchef.MakePasta();




            #endregion




            //sayHi("Mike",33);
            //sayHi("John",25);
            //sayHi("Tom",38);

            //Console.WriteLine(cube(5));

            //Console.WriteLine(GetMax(2,10,40));
            Console.ReadLine();
        }

        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for (int i = 0; i < powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }
        //    return result;
        //}

    }

    //static int GetMax(int num1, int num2, int num3)
    //{
    //    int result;

    //    if (num1 >= num2 && num1 >= num3)
    //    {
    //        result = num1;
    //    }
    //    else if (num2 >= num1 && num2 >= num3)
    //    {
    //        result = num2;
    //    }
    //    else
    //    {
    //        result = num3;
    //    }

    //    return result;

    #region Methods
    //static void sayHi(string name,int age )
    //{
    //    Console.WriteLine("Hello " + name + " You are " + age);
    //}

    //static int cube(int num)
    //{
    //    int result = num * num * num;
    //    return result;

    //}

    //static int GetMax(int num1, int num2, int num3)
    //{
    //    int result;

    //    if (num1 >= num2 && num1 >= num3)
    //    {
    //        result = num1;
    //    }
    //    else if (num2 >= num1 && num2 >= num3)
    //    {
    //        result = num2;
    //    }
    //    else
    //    {
    //        result = num3;
    //    }

    //    return result;

    #endregion

    #region Switch

    //static string GetDay(int dayNum)
    //{
    //    string dayName;

    //    switch (dayNum)
    //    {
    //        case 0: dayName = "Sunday";
    //            break;
    //        case 1: dayName = "Monday";
    //            break;
    //        case 2:dayName = "Tuesday";
    //            break;
    //        case 3:
    //            dayName = "Wednesday";
    //            break;
    //        case 4:
    //            dayName = "Thursday";
    //            break;
    //        case 5:
    //            dayName = "Friday";
    //            break;
    //        case 6:
    //            dayName = "Saturday";
    //            break;
    //        default:
    //            dayName = "Invalid Day Number";
    //            break;


    //    }


    //    return dayName;
    //}

    #endregion
}