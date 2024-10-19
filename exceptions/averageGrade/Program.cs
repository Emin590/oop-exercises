
class AvgGradeError
{
    // Declare and initialize the grades array
    static int[] grades = { 4, 7, 2, 0, 10, 4, 12 };

    // Method to get the grade for a specific course ID
    static int GetGrade(int courseid)
    {
        // Check if the course ID is within bounds
        if (courseid < 0 || courseid >= grades.Length)
        {
            throw new IndexOutOfRangeException("Course ID is out of range.");
        }

        int grade = grades[courseid];

        // Check if the grade is passing
        if (grade >= 2)
        {
            return grade; // Return the passing grade
        }
        else
        {
            // Throw an exception if the grade is not passing
            throw new Exception("Grade is not passing.");
        }
    }

    // Main method to execute the program
    static void Main(string[] args)
    {
        int count = 0; // Count of passing grades
        int sum = 0;   // Sum of passing grades

        // Iterate through each index in the grades array
        for (int courseid = 0; courseid < grades.Length; courseid++)
        {
            try
            {
                // Attempt to get the grade and add to sum
                sum += GetGrade(courseid);
                count++; // Increment count for each passing grade
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully
                Console.WriteLine($"Error for course ID {courseid}: {ex.Message}");
            }
        }

        // Calculate and print the average if there are passing grades
        if (count > 0)
        {
            Console.WriteLine("Average grade: " + (sum / count));
        }
        else
        {
            Console.WriteLine("No valid grades to calculate an average.");
        }
    }
}
