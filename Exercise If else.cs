// Initialize a Random object
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Determine the discount percentage based on days until expiration
if (daysUntilExpiration == 1) 
{
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5) 
{
    discountPercentage = 10;
}

// Check subscription status and provide appropriate messages
if (daysUntilExpiration < 1) 
{
    Console.WriteLine("Your subscription has expired!");
}
else if (daysUntilExpiration == 1) 
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save " + discountPercentage + "%!");
}
else if (daysUntilExpiration <= 5) 
{
    Console.WriteLine("Your subscription expires in: " + daysUntilExpiration + " days.");
    Console.WriteLine("Renew now and save " + discountPercentage + "%!");
}
else if (daysUntilExpiration <= 10) 
{
