namespace IdkCoDelam;

public class Memisek
{
    public void Mem()
    {
        var text = Console.ReadLine();
        for (var i = 0; i < text!.Length;i++)
        {
            Console.Write(i % 2 == 0 ? char.ToUpper(text[i]) : char.ToLower(text[i]));
        }
    }
}