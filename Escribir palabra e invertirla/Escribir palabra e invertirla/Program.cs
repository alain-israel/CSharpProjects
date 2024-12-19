
string originalWord;
string emptyString = "";
Console.WriteLine("Escribe una palabra: ");
originalWord = Console.ReadLine();

if (originalWord != null) 
{
    for (int i = originalWord.Length - 1; i >= 0; i--)
    {
       emptyString += originalWord[i];
    }
    Console.WriteLine(emptyString);
}
else
{
    Console.WriteLine("Debes escribir algo");
}