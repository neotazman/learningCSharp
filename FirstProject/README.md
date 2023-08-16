# fyi 

    1) won't work when you run program.cs, will only run from LearningC#.csproj -- edit: will run program.cs, but only after you run it from the csproj file, so there's really no point in running program.cs
        a) typing "dotnet run" into the terminal will always run the program if you're in the right folder

    2)
    using System;

    namespace MyApp // Note: actual namespace depends on the project name.
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }   -- you used to have to write this on every file, but .net 6 made it so every file inherently has this coded into the file and the code inside Main is where the code you write is placed

#  The var keyword has an important use in C#. Many times, the type of a variable is obvious from its initialization. In those cases, it's simpler to use the var keyword. The var keyword can also be useful when planning the code for an application. When you begin developing code for a task, you may not immediately know what data type to use. Using var can help you develop your solution more dynamically.