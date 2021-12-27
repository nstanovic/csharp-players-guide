// See https://aka.ms/new-console-template for more information

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
*/
