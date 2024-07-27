string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted ....");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Reverse ....");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

// Clear the first two elements of the array
Array.Clear(pallets, 0, 2);

Console.WriteLine("Cleared ....");
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}
