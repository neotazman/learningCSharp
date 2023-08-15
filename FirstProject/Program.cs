// See https://aka.ms/new-console-template for more information
// need to run LearningC#.csproj to run this code

string yourName = "dumbass";
string myName = "Tristan";
Console.WriteLine("Hello " + yourName + "!"); // basically a console log
string greeting = $"     Hello {yourName}, I'm {myName}!    "; // "$" goes before the string as opposed to before the "{}", also doesn't need "``" to run
// .Trim is a method that cuts whitespace from the beginning and end of the string -- .TrimStart and .TrimEnd trim only the expected parts
// C# methods and properties on values are TitleCase
Console.WriteLine(greeting.Trim()); 

// Console.ReadLine(); // probably was meant for an older version of C#, but it's irrelevant now