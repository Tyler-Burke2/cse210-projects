class Costume
{
    // attributes

    public string Outfit="";
    public string Footwear="";
    public string Tools="";
    public string Size="";

    // behaviors
    public void Display()
    {
        Console.WriteLine($"outfit: {Outfit}, size: {Size}");
        Console.WriteLine($"Footwear: ");
        Console.WriteLine($"Accessories: ");
    }
}