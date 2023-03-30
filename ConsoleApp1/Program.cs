// See https://aka.ms/new-console-template for more information
// This is cool ^^ makes it feel like python ngl

Console.WriteLine("Hello, World!");


// Get The input
int hours = GetInput("Hours: ", true);
int mins = GetInput("Minutes: ", false);

// Get the angles of the hands
float minDegree = GetMinuteDegree(mins);
float hourDegree = GetHourDegree(hours, mins);

// Calculate the angles between each hand
float angle = Math.Abs(minDegree - hourDegree);
if (angle > 180)
    angle = 360 - angle;

// Write the ouput
Console.WriteLine("The lesser angle between them is: "+ angle);




float GetMinuteDegree(int minutes)
{
    // a circle has 360 degrees. If we divide it into 60 we can get which degree the minute hand is at
    float minInterval = 360 / 60;

    return minutes * minInterval;
}

float GetHourDegree(int hours, int minutes)
{
    // similar to gettin the minute interval we do this with the hour but divided by 12
    float hourInterval = 360 / 12;
    // we then get the percentage of the travel of the minute hand around the clock
    float percentage = (minutes - 0f) / (59 - 0);

    // we multiply hours to hourInterval we get the degree of the hour hand if it is on that hour
    // but the hour hand does not stay static in an analog clock. It moves the minute hand moves
    // we then use this percentage to get how much percent we want the hour hand to travel to the next hour mark
    return (hours * hourInterval) + (hourInterval*percentage);

}

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
        if (int.TryParse(str, out number) && ((!isHours && number <= 59) || (isHours && number <= 12)))
        { 
            success = true;
        }
        else
        {
            Console.WriteLine("Invalid Number! Please try again");
        }

    }
    if (isHours && number==12)
    {
        return 0;
    }

    return number;
};
    