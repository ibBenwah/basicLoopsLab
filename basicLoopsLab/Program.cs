//while (true)
//{
//    Console.WriteLine("hello world");
//    Console.WriteLine("would you like to continue? (y/n)");
//    string userInput = Console.ReadLine();
//    if (userInput == "y")
//    {

//    }
//    else if (userInput == "n")
//    {
//        Console.WriteLine("goodbye");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Incorrect input. Please try again");
//    }
//}

//while (true)
//{
//    Console.Write("Please enter a number: ");
//    string userInput = Console.ReadLine();
//    int num = int.Parse(userInput);
//    for (int i = 0; i <= num; i++)
//    {
//        Console.WriteLine(i);
//    }
//    for (int j = num; j >= 0; j--)
//    {
//        Console.WriteLine(j);
//        break;
//    }
//    Console.Write("would you like to do this again? (y/n) ");
//    Console.ReadLine();
//    if (userInput == "y")
//    {
//        Console.Write("Please enter a number: ");

//    }
//    else if (userInput == "n")
//    {
//        Console.WriteLine("goodbye!");
//        break;
//    }else
//    {
//        Console.WriteLine("Please enter a valid input");
//    }
//}


// Password 13579
Console.WriteLine("what is the password? ");
string password = Console.ReadLine();
while (true)
{
    Console.WriteLine(password);
    if (password == "1")
    {
        Console.WriteLine("next");
        if (password == "3")
        {
            if(password == "5")
            {
                if(password == "7")
                {
                    if(password == "9")
                    {
                        Console.WriteLine("welcome");
                    } else
                    {
                        Console.WriteLine("not correct");
                    }
                }
            }else
            {
                Console.WriteLine("not correct");
            }
        }else { Console.WriteLine("not correct"); }
    } else
    {
        Console.WriteLine("not correct");
    }
    Console.WriteLine("incorrect");
    break;
}
     
