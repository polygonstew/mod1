
// Project 1 Mod 1
// https://github.com/polygonstew/mod1

Console.WriteLine("Welcome!");
Console.WriteLine("Lets start with simple questions!");

Console.Write("What is your name? ");
string name = Console.ReadLine();  // VS gives me squiggles in yellow CS8600
Console.Write("What is your age? ");

// int age = Console.Read(); // I changed this one from ReadLine to Read and it fixed the squigs. / UPDATE: that is wrong :(
string ageQ = Console.ReadLine(); // OK just goin to convert it into a int, I guess.
int age = Convert.ToInt32(ageQ); // That was harder than I thought.

Console.WriteLine($"Thanks {name}, {age} years old eh! \n\t That makes you ");
// Console.WriteLine($"{age} \n"); <-- Nah, looked funny

// I want the user's age to be figured into what generation nickname they are.

if (age < 10){Console.WriteLine($"\t Gen Alpha!");}
        else if (age >= 10 && age < 25)
    {
        Console.WriteLine($"\t Gen Z!");
    }
        else if (age >= 25 && age < 40)
    {
        Console.WriteLine($"\t Millennial!");
    }
        else if (age >= 40 && age < 60)
    {
        Console.WriteLine($"\t Gen X!");
    }
        else if (age >= 60 && age < 80)
    {
        Console.WriteLine($"\t Baby Boomer!");
    }
        else
    {
        Console.WriteLine($"\tGreatest Generation!");
    }

Console.Write("Now you know and knowing is half the battle! G I JOEEEEEE! ");

// Whoopy!