using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Student Grade Report Card");

        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();

        string[] subjects = { "Math", "English", "Science", "History", "Art" };
        int[] grades = new int[subjects.Length];

        for (int i = 0; i < subjects.Length; i++)
        {
            Console.Write($"Enter grade for {subjects[i]} (0-100): ");
            while (!int.TryParse(Console.ReadLine(), out grades[i]) || grades[i] < 0 || grades[i] > 100)
            {
                Console.Write("Invalid input. Enter a grade between 0 and 100: ");
            }
        }

        int total = 0;
        foreach (int grade in grades)
        {
            total += grade;
        }
        double average = total / (double)subjects.Length;

        Console.WriteLine("\n----- Report Card -----");
        Console.WriteLine($"Student: {studentName}");
        for (int i = 0; i < subjects.Length; i++)
        {
            Console.WriteLine($"{subjects[i]}: {grades[i]}");
        }
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average:F2}");

        string gradeLetter;
        if (average >= 90)
            gradeLetter = "A";
        else if (average >= 80)
            gradeLetter = "B";
        else if (average >= 70)
            gradeLetter = "C";
        else if (average >= 60)
            gradeLetter = "D";
        else
            gradeLetter = "F";

        Console.WriteLine($"Grade: {gradeLetter}");
    }
}
