// variables in c#
string studentName = "Abeba";
string studentId = "STU-001";
int enrollmentCount = 3;
decimal grantAmount = 1999.99m; // 'm' suffix marks a decimal literal
DateTime enrolledAt = DateTime.UtcNow;
string? campusRegion = null;
Console.WriteLine($"Student: {studentName} ({studentId})");
Console.WriteLine($"Enrollments: {enrollmentCount}");
Console.WriteLine($"Grant Amount: {grantAmount:C}");
Console.WriteLine($"Enrolled At: {enrolledAt}");
Console.WriteLine($"Campus Region: {campusRegion ?? "Not specified"}");