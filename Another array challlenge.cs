/*
  The following code creates five random OrderIDs
  to test the fraud detection process. OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

// Initialize a Random object
Random random = new Random();
string[] orderIDs = new string[5];

// Generate five random OrderIDs
for (int i = 0; i < orderIDs.Length; i++)
{
    // Generate a random letter from A to E
    int prefixValue = random.Next(65, 70); // ASCII values for A to E
    string prefix = Convert.ToChar(prefixValue).ToString();

    // Generate a random three-digit number
    string suffix = random.Next(1, 1000).ToString("000");

    // Combine the prefix and suffix to form the OrderID
    orderIDs[i] = prefix + suffix;
}

// Output each generated OrderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
