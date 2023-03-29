// See https://aka.ms/new-console-template for more information
// This is cool ^^ makes it feel like python ngl

Console.WriteLine("Hello, World!");


int hours = GetInput("Hours: ", true);

int mins = GetInput("Minutes: ", false);

Console.WriteLine("Hours: " + hours);
Console.WriteLine("Minutes: "+ mins);

// get the angles of the hands

// calculate the angles between each hand



int GetInput(string msg, bool isHours) {
    // We first get the string you will be using to ask the user for input.
    // Then we ask if the input is the input for hours or the input for minutes

    bool success = false;
    int number = 0;

    while (!success)
    {
        Console.Write(msg);
        string str = Console.ReadLine();
        
        // We first check if the string is a number then we check if it is an hour to see it dont exceed 11 and if mins it wont exceed 59
        if (int.TryParse(str, out number) && ((!isHours && number <= 59) || (isHours && number <= 11)))
        { 
            success = true;
        }
        else
        {
            Console.WriteLine("Invalid Number! Please try again");
        }

    }

    return number;
};
    