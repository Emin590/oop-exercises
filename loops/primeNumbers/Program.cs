int val = 3; // Start checking from 3

while (val <= 100) 
{
    bool isPrime = true; // Initialize isPrime to true for each number

    if (val <= 1) // Numbers less than or equal to 1 are not prime
    {
        isPrime = false;
    }
    else
    {
        // Check for divisibility from 2 to the square root of val
        for (int i = 2; i <= Math.Sqrt(val); i++)
        {
            if (val % i == 0) // If val is divisible by i
            {
                isPrime = false; // Not a prime number
                break; // No need to check further
            }
        }
    }

    // Output the result for the current value of val
    Console.WriteLine(val + " is prime: " + isPrime);
    
    val++; // Increment val to check the next number
}