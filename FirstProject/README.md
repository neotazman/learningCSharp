#fyi 

    1) won't work when you run program.cs, will only run from LearningC#.csproj -- edit: will run program.cs, but only after you run it from the csproj file, so there's really no point in running program.cs

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

