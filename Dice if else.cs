// Initialize a Random object
Random dice = new Random();

// Roll the dice three times, each roll between 1 and 6
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Calculate the total of the three rolls
int total = roll1 + roll2 + roll3;

// Output the results of the rolls
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Check for triples
if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
// Check for doubles
else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// Determine if the player wins or loses
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}
