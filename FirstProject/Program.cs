// See https://aka.ms/new-console-template for more information
// need to run LearningC#.csproj to run this code

string yourName = "dumbass";
string myName = "Tristan";
Console.WriteLine("Hello " + yourName + "!"); // basically a console log
string greeting = $"     Hello {yourName}, I'm {myName}!    "; // "$" goes before the string as opposed to before the "{}", also doesn't need "``" to run

// .Trim is a method that cuts whitespace from the beginning and end of the string -- .TrimStart and .TrimEnd trim only the expected parts
// C# methods and properties on values are TitleCase
Console.WriteLine(greeting.Contains("Hello")); 
greeting = greeting.Trim().Replace("Hello", "Greetings");
Console.WriteLine(greeting);
Console.Write("Hello "); // .Write does the same thing as .WriteLine except it doesn't start a new line with each Console
Console.WriteLine(yourName);

// Console.ReadLine(); // probably was meant for an older version of C#, but it's irrelevant now

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Console.WriteLine("a" == "a ".Trim()); // you can add string methods to strings without saving them as a variable

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Random coin = new Random();
// int flip = coin.Next(0, 2); // returns a value >= the first number and < the second (will never return 2)
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// string permission = "Admin|Manager";
// int level = 55;

// if(permission.Contains("Admin")) {
//     if(level > 55) {
//         Console.WriteLine("Welcome, Super Admin user.");
//     } else {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// } // I didn't finish this challenge, i just want to skip to the learning

// var message = "Hello, world"; // var can be set to any data type -- 
// message = 6; // var implies the first data type set to it, so it can't be reset to a different data type

// int[] data = new int[3]; // instantiating an int array -- note: does not fill the array

// Console.WriteLine(2.625); // The compiler defaults to a double literal when a decimal number is entered without a literal suffix.