// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    private static void Main(string[] args)
    {
        Console.WriteLine("halo user" + User(" kiwil"));
    }

    public static Metode User<Metode>(Metode a)
    {
        return (dynamic)a;
    }
}