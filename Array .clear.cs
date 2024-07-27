string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

// Before clearing
Console.WriteLine($"Before: {pallets[0].ToLower()}");

// Clear the first two elements of the array
Array.Clear(pallets, 0, 2);

// Check if the first element is null before printing
if (pallets[0] != null)
{
    Console.WriteLine($"After: {pallets[0].ToLower()}");
}
else
{
    Console.WriteLine("After: null");
}

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

// Output the contents of the array after clearing
foreach (var pallet in pallets)
{
    if (pallet != null)
    {
        Console.WriteLine($"-- {pallet}");
    }
    else
    {
        Console.WriteLine("-- null");
    }
}
