using static System.Console;

class GreenvilleRevenue
{
    static void Main() 
    {
        const int ENTRANCE_FEE = 25;
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        int num;
        int revenue;
        Contestant[] contestants = new Contestant[MAX_CONTESTANTS];
        num = getContestantNumber(MIN_CONTESTANTS, MAX_CONTESTANTS);
        revenue = num * ENTRANCE_FEE;
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));
        getContestantData(num, contestants);
        getLists(num, contestants);

        // methods we neeed: 
        // getContestantNumber
        // getContestantData
        // getLists

        // Contestant is a class
        // public static parallel arrays for the tallent codes S and Singing
        // 
        
    }
    // private method for use only by GreenvilleRevenue class
    // returns an int; takes input paramters of min and max contestants
    private static int getContestantNum(int min, int max)
    {
        //------------------------- Last Year's Contestants ---------------------------------//
        // prompt for number of users and ReadLine input
        string lastYear;
        string thisYear;
        WriteLine("Enter number of contestants for Last year: ");
        lastYear = ReadLine();
        int num = 0;
        bool success = int.TryParse(lastYear, out num);

        // check if it can be parsed to an int; prompt for correct input and ReadLine
        // check if it can be parsed to an int;
        while (success != true)
        {
            WriteLine("Enter number of contestants for Last year >> ");
            lastYear = ReadLine();
            num++;
            WriteLine("You've enter the incorrect value {0} times.", num);
        }

        if (success)
        {
            WriteLine("You've entered the correct value type! :)");
        }
        else
        {
            WriteLine("Incorrect value type entered :( Please enter interger values only >> ");
            lastYear = ReadLine();
        }

        // while the number is outside the range (while userInput is less than 0 or greater than 30)
        // else, if number is outside the range tell user they must enter number between min and max values
        // prompt for number of user and ReadLine input

        while (lastYear < min || lastYear > max)
        {
            if (lastYear != min || lastYear != max)
            {
                WriteLine("Number must be between {0} and {1}", min, max);
                Write("Enter number of contestants last year >> ");
                lastYear = ReadLine();
            }
        }
        //Returns value because lastYear contestants is correct
        WriteLine("Last years contestants were {0}", lastYear);

        //---------------------- This Years Contestants-----------------------------------//

        WriteLine("Enter number of contestants for This year: ");
        thisYear = ReadLine();
        int num = 0;
        bool success = int.TryParse(thisYear, out num);

        // check if it can be parsed to an int; prompt for correct input and ReadLine
        // check if it can be parsed to an int;
        while (success != true)
        {
            WriteLine("Enter number of contestants for Last year >> ");
            thisYear = ReadLine();
            num++;
            WriteLine("You've enter the incorrect value {0} times.", num);
        }

        if (success)
        {
            WriteLine("You've entered the correct value type! :)");
        }
        else
        {
            WriteLine("Incorrect value type entered :( Please enter interger values only >> ");
            thisYear = ReadLine();
        }

        // while the number is outside the range (while userInput is less than 0 or greater than 30)
        // else, if number is outside the range tell user they must enter number between min and max values
        // prompt for number of user and ReadLine input

        while (thisYear < min || thisYear > max)
        {
            if (thisYear != min || thisYear != max)
            {
                WriteLine("Number must be between {0} and {1}", min, max);
                Write("Enter number of contestants last year >> ");
                thisYear = ReadLine();
            }
        }
        //Returns value because thisYear contestants is correct
        WriteLine("Last years contestants were {0}", thisYear);
    }

    private static void getContestantData(int num, Contestant[] contestants)
    {
        // initialize any local variables needed for thgh rough the numbder of contestants
        const int maxContestant = 30;
        string[] names = new string[maxContestant];
        string conName;
        string conCode;

        // prompt for contestant name and ReadLine
        WriteLine("Enter the contestants name >> ");
        names[x] = ReadLine();

        // prompt for talent codes; present the talent codes and talent string; reads userInput
        WriteLine("Enter a Valid talent codes: singing = S, dancing = D, musical = M, other = O");
        conCode = ReadLine();

        // parse to the string input to a char
        int num = 0;
        bool success = char.TryParse(conCode, out num);
        if (success)
        {
            return success;
        }
        else
        {
            WriteLine("Cannot convert to char. :(");
        }

        // create a new contestant object, and assign fields for name and talent code
        // process next contestant
    }
        class Contestant
        {
            // Parallel Arrays for talents
            public static char[] talentCodes = { 'S', 'D', 'M', 'O' };
            public static string[] talentStrings = { "Singing", "Dancing", "Musical Instrument", "Other" };

            // fields to store in Contestant object
            // need fields for Name and TalentCode
            public string Name { get; set; }  // use auto-properties here
            private char talentCode;
            private string talent;

            // public method for get and set TalentCode
            public char TalentCode
            {
                get
                {
                    return talentCode;
                }

                // check talent code value and set talent code and string
                set
                {
                    int talentCodesLength = talentCodes.Length;
                    for (int x = 0; x < talentCodesLength; ++x)
                    {
                        if (value == talentCodes[x])
                        {
                            talentCode = value;
                            talent = talentStrings[x];
                        }
                        else
                        {
                            talentCode = 'I';
                            talent = "Invalid";
                        }
                    }
                    // End of for Loop
                }
                // End of set

                // public method for get TalentString
            public string TalentString
            {
                get
                {
                    return talent;
                }
            }
        }
    // End public method for get TalentString
    // no need to set TalentString if we know position of TalentCode; parallel arrays 
    }
    // End of Contestant class
}
// End Class GreenvilleRevenue
   