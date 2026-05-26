using System;

class Program
{
    static void Main()
    {
        decimal grantPerStudent = 1999.99m;
        int totalStudents = 100_000;

        decimal totalAllocation = grantPerStudent * totalStudents;

        Console.WriteLine($"Grant Per Student : {grantPerStudent:C}");
        Console.WriteLine($"Total Students    : {totalStudents:N0}");
        Console.WriteLine($"Total Allocation  : {totalAllocation:C}");
    }
}