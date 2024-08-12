
List<string> guestList = new List<string>() // Creating the list consist guest names
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};

Console.WriteLine("-------**Davetliler**------");

foreach (string guest in guestList) // Printing the elements of the list
{
    Console.WriteLine(guest);
}