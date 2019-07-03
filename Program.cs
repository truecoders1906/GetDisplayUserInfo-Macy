using System;

namespace playgroud2
{
    class Program
    {
        static string AskAboutAge(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }

            return response;
        }
        static string AskAboutYear(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }
            return response;
        }
        static string AskAboutColor(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }
            return response;
        }
        static string AskAboutAnimal(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }
            return response;
        }
        static string AskHowManyDogs(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }
            return response;
        }
        static string AskHowManyCats(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }
            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, my name is Macy.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("I think we could be friends");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("and your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Dont worry I am not going to Facebook stock you......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Is it okay if I ask you a couple of questions " + firstName + "?");
            string okayToAsk = Console.ReadLine();
            if (okayToAsk == "no")
            {
                int numberOfTimesToAsk = 1;
                do
                {
                    Console.WriteLine("Thats fine. I guess..... its a big world!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("I will just have to find another friend");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Some where else!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("In this big big world........");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Unless you have changed your mind " + firstName + "?");
                    okayToAsk = Console.ReadLine();
                    ++numberOfTimesToAsk;
                } while (okayToAsk == "no" && numberOfTimesToAsk <= 2);
            }
            if (okayToAsk == "yes" ||okayToAsk == "Yes")
              {
                Console.WriteLine("Great, lets start with your age.");
                System.Threading.Thread.Sleep(1000);
                string askAge = AskAboutAge("How old are you?");
                int age = int.Parse(askAge);
                if (age <= 10)
                    {
                        Console.WriteLine("WWoow so your like still peeing the bed.");
                    }
                else if (age <= 17)
                    {
                        Console.WriteLine("Soooo... you can't legaly do anything yet.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Buuuuummmmmeeeerrrr!!!!");
                    }
                else if (age <= 29)
                    {
                        Console.WriteLine("I bet you don't want to adult today!!");
                    }
                else if (age <= 39)
                    {
                        Console.WriteLine("Your 20s are for parting and your 30s....");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("There for figuring out why you wanted to party so hard in your 20s.");
                    }
                else if (age <= 49)
                    {
                        Console.WriteLine("Let me politly suggest, its time to start lying about your age. ");
                    }
                else if (age <= 59)
                    {
                        Console.WriteLine("Your 40's are the old age of youth, your 50's are the youth of old age.");
                    }
                else if (age <= 69)
                    {
                        Console.WriteLine("60s might be the new 40s but 9pm is the new Midnight.");
                    }
                else if (age >= 70)
                    {
                        Console.WriteLine("The other day I was driving past a cemetary. ");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("I could have sworen I saw a grave with your name on it!");
                    }

                System.Threading.Thread.Sleep(2000);
                string birthYear = AskAboutYear("What year would you have been born?");
                int year = int.Parse(birthYear);
                if (year == 1920 || year == 1932 || year == 1944 || year == 1956 || year == 1968 || year == 1980 || year == 1992 || year == 2004 || year == 2016)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Monkey!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("OOhhh EEEhhh OOHH EEhh aaaahhh!!!!!");
                    }
                else if (year == 1921 || year == 1933 || year == 1945 || year == 1957 || year == 1969 || year == 1981 || year == 1993 || year == 2005 || year == 2017)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Rooster!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Ccock-a-doodle-doo!!!!");
                    }
                else if (year == 1922 || year == 1934 || year == 1946 || year == 1958 || year == 1970 || year == 1982 || year == 1994 || year == 2006 || year == 2018)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Dog!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Rrruff-RRrufff!!!!");
                    }
                else if (year == 1923 || year == 1935 || year == 1947 || year == 1959 || year == 1971 || year == 1983 || year == 1995 || year == 2007 || year == 2019)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Pig!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Oink-oink!!!!");
                    }
                else if (year == 1912 || year == 1924 || year == 1936 || year == 1948 || year == 1960 || year == 1972 || year == 1984 || year == 1996 || year == 2008)

                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Rat!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("EEkkk-eekk!!!!");
                    }
                else if (year == 1913 || year == 1925 || year == 1937 || year == 1949 || year == 1961 || year == 1973 || year == 1985 || year == 1997 || year == 2009)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Ox!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("MMMMmmoooooooooooo!!!!");
                    }
                else if (year == 1914 || year == 1926 || year == 1938 || year == 1950 || year == 1962 || year == 1974 || year == 1986 || year == 1998 || year == 2010)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Tiger!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Grrrauuuuuuuuuu!!!!");
                    }
                else if (year == 1915 || year == 1927 || year == 1939 || year == 1951 || year == 1963 || year == 1975 || year == 1987 || year == 1999 || year == 2011)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Rabbit!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Squeak,squeak!!!!");
                    }
                else if (year == 1917 || year == 1929 || year == 1941 || year == 1953 || year == 1965 || year == 1977 || year == 1989 || year == 2001 || year == 2013)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Snake!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("SsssssssssssSSsssss!!!!");
                    }
                else if (year == 1918 || year == 1930 || year == 1942 || year == 1954 || year == 1966 || year == 1978 || year == 1990 || year == 2002 || year == 2014)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Horse!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Neigghhhhhhh!!!!");
                    }
                else if (year == 1919 || year == 1931 || year == 1943 || year == 1955 || year == 1967 || year == 1979 || year == 1991 || year == 2003 || year == 2015)
                    {
                        Console.WriteLine("HHhhhhmmm " + year + " was the year of the Sheep!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Bbbbaaaaaaahhhhh!!!!");
                    }

                Console.WriteLine("Okay next question.");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("My favorite color is turquoise.");
                System.Threading.Thread.Sleep(1000);
                string color = AskAboutColor("Whats your favorite?");
                if (color == "turquoise")
                    {
                        Console.WriteLine("I agree, its the best!");
                    }
                else if (color == "red")
                    {
                        Console.WriteLine("I hope you dont have anger issues.");
                    }
                else if (color == "green")
                    {
                        Console.WriteLine("I bet you like nature, I love nature");
                    }
                else if (color == "black")
                    {
                        Console.WriteLine("I bet you're mysterious!");
                    }
                else if (color == "blue")
                    {
                        Console.WriteLine("Some people say turquoise is green but i disagree....");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("It' definitely a shade of blue");
                    }
                else
                    {
                        Console.WriteLine("Thats nice too");
                    }

                System.Threading.Thread.Sleep(1000);
                string animalPrefrerence = AskAboutAnimal("Do you like dogs or cats or both?");
                if (animalPrefrerence == "dogs")
                {
                    string dogNumber = AskHowManyDogs("Me to, I love dogs. How many dogs do you have?");
                    int amountOfDogs = Int32.Parse(dogNumber);

                    if (amountOfDogs == 0)
                    {
                        Console.WriteLine("You should adopt one!");
                    }
                    else if (amountOfDogs <= 3)
                    {
                        Console.WriteLine("I bet they are adorable");
                    }
                    else
                    {
                        Console.WriteLine("Your house must be a jungle");
                    }
                }
                else if (animalPrefrerence == "cats")
                {
                   string catNumber = AskHowManyCats("How many cats do you have?");
                   int amountOfCats = Int32.Parse(catNumber);

                   if (amountOfCats == 0)
                   {
                        Console.WriteLine("You should adopt one!");
                   }
                   else if (amountOfCats <= 3)
                   {
                        Console.WriteLine("I bet they are adorable");
                   }
                   else
                   {
                        Console.WriteLine("Your house must be a jungle....");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("I bet you're never lonely");
                   }
                }
                else
                {
                    Console.WriteLine("I like dogs best but catss are nice too.");
                }
                if (age >= 19 && age <= 45 || color == "turquoise" || animalPrefrerence == "dog")
                {
                    Console.WriteLine("Well know that i know your name " + firstName + " " + lastName + "!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You are " + age + ", and born in " + year + ".");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Plus your favorite color is " + color + ".");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("and you like " + animalPrefrerence + "!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("We can be friends. Here is my number. Lets hang out!!!!");
                }
               else 
                {
                    Console.WriteLine("Well know that i know your name " + firstName + " " + lastName + "!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You are " + age + ", and born in " + year + ".");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Plus your favorite color is " + color + ".");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("and you like " + animalPrefrerence + "!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Well I'm verry sorry but i just dont think we can be friends.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("We are just to diffrent, but i still hope you have a wonderful day!");
                }
            }
        }
    }
}