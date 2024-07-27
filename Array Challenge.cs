// Define an array of order IDs
string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// Iterate through each order ID in the array
foreach (string item in orderIds)
{
    // Check if the order ID starts with the letter 'B'
    if (item.StartsWith("B"))
    {
        // Print the order ID if it starts with 'B'
        Console.WriteLine(item);
    }
}
