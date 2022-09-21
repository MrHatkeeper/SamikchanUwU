namespace IdkCoDelam;

public class Nasobilka
{
    public static void Nasob()
    {
         var input = int.Parse(Console.ReadLine()!);


        for (var col = 1; col < input; col++)
        {
            Console.WriteLine("");
            var outText = "";
            for (var row = 1; row < input; row++)
            {
                outText += (row * col) + " ";
            }
            Console.Write(outText);
        }
    }
    
}