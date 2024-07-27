// Initialize a Random object
Random dice = new Random();

// Roll the dice with different ranges
int roll1 = dice.Next(); // No upper limit specified
int roll2 = dice.Next(101); // Upper limit specified as 101 (0 to 100)
int roll3 = dice.Next(50, 101); // Lower limit specified as 50, upper limit as 101 (50 to 100)

// Output the results of the rolls
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
