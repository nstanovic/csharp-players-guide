// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;

// Console.WriteLine("Hello, Nick!");

// make 5 WriteLine statements
// Console.WriteLine("Hey there!");
// Console.WriteLine("How are you?");
// Console.WriteLine("What's up?");
// Console.WriteLine("I'm good.");
// Console.WriteLine("That's great!");

// ask who wants bread and then give them a bread
// Console.WriteLine("Bread is ready!");
// Console.WriteLine("Who wants bread?");
// string breadRecipient = Console.ReadLine();
// Console.WriteLine($"{breadRecipient} got bread.");

// add different styles of comments to this code
// Console.WriteLine("What kind of thing are we talking about?");
// string a = Console.ReadLine();
// ask user for the noun
// Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// string b = Console.ReadLine();
// ask user for the adjective
// string c = "of Doom";
// string d = "3000";
/*
let user know how bad ass it is
everyone loves of Dooms 
and 3000s
*/
// Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");

// part 1. declare and assign 14 variables of different types
// int, string, bool, double, float, char, decimal, long, short, byte, uint, ulong, ushort
/*
int age = 38;
string name = "Nick";
bool isMale = true;
double height = 5.9;
float weight = 171.5f;
char hairColor = 'b';
decimal shoeSize = 10.5m;
long largestLong = 9_223_372_036_854_775_807;
short smallestShort = -32_768;
byte dinnersEaten = 0;
uint largestUintNumber = 4_294_967_295;
ulong biggestUlong = 18_446_744_073_709_551_615;
ushort biggestUshort = 65_535;

// part 2. print out the variables
Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine(isMale);
Console.WriteLine(height);
Console.WriteLine(weight);
Console.WriteLine(hairColor);
Console.WriteLine(shoeSize);
Console.WriteLine(largestLong);
Console.WriteLine(smallestShort);
Console.WriteLine(dinnersEaten);
Console.WriteLine(largestUintNumber);
Console.WriteLine(biggestUlong);
Console.WriteLine(biggestUshort);

// part 3. assign a new value to each variable
age = 24;
name = "Becki";
isMale = false;
height = 5.2;
weight = 109.5f;
hairColor = 'r';
shoeSize = 5.5m;
largestLong = 8_223_372_036_854_775_807;
smallestShort = -2_768;
dinnersEaten = 1;
largestUintNumber = 4_294_967_294;
biggestUlong = 18_446_744_073_709_551_613;
biggestUshort = 65_533;

// part 4. print out the new values
Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine(isMale);
Console.WriteLine(height);
Console.WriteLine(weight);
Console.WriteLine(hairColor);
Console.WriteLine(shoeSize);
Console.WriteLine(largestLong);
Console.WriteLine(smallestShort);
Console.WriteLine(dinnersEaten);
Console.WriteLine(largestUintNumber);
Console.WriteLine(biggestUlong);
Console.WriteLine(biggestUshort);
*/
/*
// part 1. ask user for base and height of triangle
double baseOfTriangle = double.Parse(Console.ReadLine());
double heightOfTriangle = double.Parse(Console.ReadLine());

// part 2. calculate area of triangle
double areaOfTriangle = (baseOfTriangle * heightOfTriangle) / 2;

// part 3. print out area of triangle
Console.WriteLine(areaOfTriangle);
*/
/*
// part 1. ask user for number of chocolate eggs
Console.WriteLine("How many chocolate eggs do you have?");
int chocolateEggs = int.Parse(Console.ReadLine());

// part 2. distribute eggs among 4 sisters and give remainder to pet duckbear
int eggsPerSister = chocolateEggs / 4;
int eggsForDuckbear = chocolateEggs % 4;

// part 3. what are 3 amounts of eggs where duckbear gets more eggs than any of the sisters?
// choose 3 odd numbers because they can't be split evenly
if (eggsForDuckbear > eggsPerSister)
{
    Console.WriteLine("Duckbear is happy because he gets more eggs than any of the sisters.");
}
else
{
    Console.WriteLine("Duckbear is sad because he gets less eggs than any of the sisters.");
}
*/
/*
// part 1. there are 3 users: Melik, Casik, and Balik
// ask each person how many estates, duchies, and provinces they own
Console.WriteLine("Melik, how many estates do you own?");
int melikEstates = int.Parse(Console.ReadLine());
Console.WriteLine("Melik, how many duchies do you own?");
int melikDuchies = int.Parse(Console.ReadLine());
Console.WriteLine("Melik, how many provinces do you own?");
int melikProvinces = int.Parse(Console.ReadLine());

Console.WriteLine("Casik, how many estates do you own?");
int casikEstates = int.Parse(Console.ReadLine());
Console.WriteLine("Casik, how many duchies do you own?");
int casikDuchies = int.Parse(Console.ReadLine());
Console.WriteLine("Casik, how many provinces do you own?");
int casikProvinces = int.Parse(Console.ReadLine());

Console.WriteLine("Balik, how many estates do you own?");
int balikEstates = int.Parse(Console.ReadLine());
Console.WriteLine("Balik, how many duchies do you own?");
int balikDuchies = int.Parse(Console.ReadLine());
Console.WriteLine("Balik, how many provinces do you own?");
int balikProvinces = int.Parse(Console.ReadLine());

// part 2. add up the point total for each person
// estates = 1 point, duchies = 3 points, provinces = 6 points
int melikPoints = (melikEstates * 1) + (melikDuchies * 3) + (melikProvinces * 6);
int casikPoints = (casikEstates * 1) + (casikDuchies * 3) + (casikProvinces * 6);
int balikPoints = (balikEstates * 1) + (balikDuchies * 3) + (balikProvinces * 6);
Console.WriteLine("");

// part 3. print out the total points for each person
Console.WriteLine("Melik has " + melikPoints + " points.");
Console.WriteLine("Casik has " + casikPoints + " points.");
Console.WriteLine("Balik has " + balikPoints + " points.");
*/

/*
  fireballs are being launched into the city at user chosen x and y coordinates
  four crew members must each hold a corner of the shield to block
  one crew member must stand north, south, east, and of the epicenter to block


// part 1. make the console window title to be "Defense of Consolas"
Console.Title = "Defense of Consolas";

// part 2. ask user for an x and y coordinate to launch the fireball
Console.Write("Enter an x coordinate (row) to launch the fireball: ");
int xCoordinate = int.Parse(Console.ReadLine());
Console.Write("Enter a y coordinate (column) to launch the fireball: ");
int yCoordinate = int.Parse(Console.ReadLine());

// part 3. compute the x and y coordinates of each corner of the shield
int eastCornerX = xCoordinate + 1;
int westCornerX = xCoordinate - 1;
int northCornerY = yCoordinate + 1;
int southCornerY = yCoordinate - 1;

// part 4. give each crew a coordinate to stand in
// part 4a. make the deployment instructions a different color
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Deploy to:");
Console.WriteLine($"({eastCornerX}, {yCoordinate})");;
Console.WriteLine($"({westCornerX}, {yCoordinate})");;
Console.WriteLine($"({xCoordinate}, {northCornerY})");;
Console.WriteLine($"({xCoordinate}, {southCornerY})");;
Console.ResetColor();

// part 5. play a beep when the results have been displayed
Console.Beep();
*/
/*
// Repairing The Clocktower
// take number as input from user
// fix the clock by making the pendulum tick on even numbers and tock on odd numbers
Console.WriteLine("Please enter a number: ");
int clock = Int32.Parse(Console.ReadLine());
bool tick = clock % 2 == 0;

if (tick)
    Console.WriteLine("tick");
else
    Console.WriteLine("tock");
*/

/* Watchtower
Watchtowers in the area can alert you when the enemy is spotted
with your help they d which direction the enemy is coming from


// part 1. Ask user for x and y values
Console.WriteLine("enter x coordinate: ");
int x = Int32.Parse(Console.ReadLine());
Console.WriteLine("enter y coordinate: ");
int y = Int32.Parse(Console.ReadLine());

// part 2. Determine the direction of the enemy relative to the given coordinates
// for reference, the enemy is located at (0,0)
if (x == 0 && y == 0)
    Console.WriteLine("The enemy is here!");
else if (y > 0 && x > 0)
    Console.WriteLine("The enemy is to the northeast!");
else if (y > 0 && x == 0) 
    Console.WriteLine("The enemy is to the north!");
else if (y > 0 && x < 0)
    Console.WriteLine("The enemy is to the northwest!");
else if (y == 0 && x < 0)
    Console.WriteLine("The enemy is to the west!");
else if (y < 0 && x < 0)
    Console.WriteLine("The enemy is to the southwest!");
else if (y < 0 && x == 0)
    Console.WriteLine("The enemy is to the south!");
else if (y < 0 && x > 0)
    Console.WriteLine("The enemy is to the southeast!");
else if (y == 0 && x > 0)
    Console.WriteLine("The enemy is to the east!");
*/

/* Buying Inventory
A nearby shop is disorganized and needs your help to report the price of each item
use a switch statement to determine the price of each item
*/
/*
// part 1. Ask user for their name
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine();

double discount = 1;

// part 2. If name is "Nick" give 50% discount
if (name == "Nick")
{
    discount = .5;
    Console.WriteLine("Welcome, " + name + "! You get a 50% discount!");
}
else
{
    Console.WriteLine("Welcome, " + name + "!");
}
Console.WriteLine();

// part 3. Display a menu of items
Console.WriteLine("The following items are available: ");
Console.WriteLine("1 - Rope ");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies ");
Console.WriteLine();
// part 4. Ask user to select an item
Console.WriteLine("What number do you want to see the price of?");
int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
// part 5. Use switch statements or a switch to determine item's cost
string response = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
};

// part 6: Store the price of each items in a switch expression
int price = choice switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
};

// part 6. display the item and cost to user with a discount
Console.WriteLine($"The price of {response} is {price * discount} gold");   
/* Discounted Inventory
modify previous exercise to ask for person's name
if name is my name, display a 50% discount
*/

/* The Prototype
 Hunt down the airship
 Two users: the airship pilot and the hunter
 pilot picks a space between 0 - 100 to hide airship
 hunter picks a space to guess which space the ship is hiding
 we tell the hunter if the number is too high or too low 
 we keep asking until hunter finds the ship
 if correct space chosen we congratulate the hunter
*/
/*
// Part 1. Ask pilot for the space number to hide the airship
// If number is less than 0 or grater than 100 keep asking
int shipHidingSpot;

do
{
    Console.WriteLine("Pick a space between 0 and 100 to hide your ship");
    shipHidingSpot = Convert.ToInt32(Console.ReadLine());
}
while (shipHidingSpot is < 0 or > 100);

// Part 2. Ask hunter to guess the location number of the airship
// Keep asking the hunter to guess until finds the ship
int huntersSpotChoice;

do
{
    Console.WriteLine("Pick a space between 0 and 100 to check for the airship");
    huntersSpotChoice = Convert.ToInt32(Console.ReadLine());
    if (huntersSpotChoice == shipHidingSpot)
    {
        Console.WriteLine("Congratulations, you found the ship!");
    }
    else if (huntersSpotChoice < shipHidingSpot)
    {
        Console.WriteLine("Too low, try again!");
    }
    else if (huntersSpotChoice > shipHidingSpot)
    {
        Console.WriteLine("Too high, try again!");
    }
    Console.WriteLine();
} 
while (huntersSpotChoice != shipHidingSpot);
*/

/* The Magic Cannon
A magic cannon draws power from two gems: fire gem and electric gem
The cannon is fired 100 times
Cannon will fire normal blasts for any 
Every third turn a fire gem activates for a fire blast
Every fifth turn the electric gem activates for an electric blast
If a turn activates both the fire and electric gems there is a fiery electric blast
The 3 different types of blasts each need their own colors
*/

// part 1. 'for' loop to fire cannon 100 times
for (int shots=1; shots < 101; shots++)
// part 2. if statement to indicate fire blast every 3 turns
    if (shots % 3 == 0)
        Console.WriteLine("Fire Blast");
// part 3. if statement to indicate electric blast every 5 turns
    else if (shots % 5 == 0)
        Console.WriteLine("Electric Blast");
// part 4. if statement to indicate fiery electric blast if both parts 2 and 3 are true


// part 5. else statement to indicate normal shot on all other turns


// part 6. go back and add colors to the special blasts

