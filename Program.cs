using System;

public class Course
{
    // Required init-only property
    public required string Code { get; init; }

    // Auto-property validation using 'field'
    public required string Title
    {
        get;
        set => field = !string.IsNullOrWhiteSpace(value)
            ? value
            : throw new ArgumentException(
                "Title cannot be empty or whitespace.",
                nameof(value));
    }

    // Capacity validation
    public int Capacity
    {
        get;
        set => field = value > 0
            ? value
            : throw new ArgumentOutOfRangeException(
                nameof(value),
                "Capacity must be greater than zero.");
    }

    public int EnrolledCount { get; set; }
}

class Program
{
    static void Main()
    {
        // Valid object
        var course = new Course
        {
            Code = "CS-401",
            Title = "Advanced C#",
            Capacity = 30
        };

        Console.WriteLine(
            $"Course: {course.Title} (Capacity: {course.Capacity})");

        // Invalid capacity
        try
        {
            course.Capacity = -5;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }

        // Invalid title
        try
        {
            course.Title = "";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
    }
}