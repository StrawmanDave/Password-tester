// David Barlow 11/2/2024 Homework #27 Validate Password

using System.Diagnostics;

Console.Clear();

Console.WriteLine("The program ran");

Debug.Assert(ValidPassword("Monkey") == false);
Debug.Assert(ValidPassword("Gorillas") == true);


bool ValidPassword(string pw)
{
    int characterAmount = 0;
    for(int i = 0; i<pw.Length; i++)
    {
        characterAmount ++;
    }
    if(characterAmount < 8)
    {
        return false;
    }else
    {
        return true;
    }
}