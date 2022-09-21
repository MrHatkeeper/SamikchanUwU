namespace IdkCoDelam;


public class Palindrome
{
    public static void Pal()
    {
        

        var mbyPalindrome = Console.ReadLine();


        var isPal = true;
        for (var i = 0; i < (mbyPalindrome!.Length / 2); i++)
        {
            if (mbyPalindrome[i] == mbyPalindrome[mbyPalindrome.Length - i - 1]) continue;
            isPal = false;
            break;
        }

        if (isPal)
        {
            Console.WriteLine("Je palindrom");
        }
        else
        {
            Console.WriteLine("Není palindrom");
        }
    }    
}

