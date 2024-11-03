// David Barlow 11/2/2024 Homework #27 Validate Password

using System.Diagnostics;
using System.Linq.Expressions;

Console.Clear();

Console.WriteLine("The program ran");

// cannot have less than eight charctes
Debug.Assert(ValidPassword("Monkey") == false);
Debug.Assert(ValidPassword("Gorillas") == true);

// must have one capital letter
Debug.Assert(ValidPassword("gorillas") == false);
Debug.Assert(ValidPassword("Gorillas") == true);

// must not have an asterisk in it\
Debug.Assert(ValidPassword("Gorillas*") == false);
Debug.Assert(ValidPassword("*Gorillas") == false);

// must have number
Debug.Assert(ValidPassword("Gorillas") == false);
Debug.Assert(ValidPassword("Gorillas4") == true);

// must have on special character that is not a asterisk
Debug.Assert(ValidPassword("Gorill@s*") == false);
Debug.Assert(ValidPassword("Gorill@s") == true);


bool ValidPassword(string pw)
{
    string specialCh = @"!@#$%^&()<>?.,{}[]`~=+-/|_" + "\"";
    char[] ChSpecial = specialCh.ToCharArray();
    int characterAmount = 0;
    int i = 0;
    for(i = 0; i<pw.Length; i++)
    {
        characterAmount ++;
    }

    if(characterAmount >= 8 && pw.Any(char.IsUpper) && !pw.Contains("*"))
    {
        return true;
    }else
    {
        return false;
    }
}