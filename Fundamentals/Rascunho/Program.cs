var list = new List<string>
{
  "one",
  "TWO",
  "TWO",
  "THREE",
  "TWO!!!",
  "four",
  "21321TWO2131&&^@"
};

var list2 = GetOnlyUpperCaseWords(list);

foreach (var word in list2)
{
    Console.WriteLine(word);
}

Console.ReadKey();

static List<string> GetOnlyUpperCaseWords(List<string> words)
{

    bool isUpperCase = false;
    List<string> upperWords = new List<string>();

    foreach (var word in words)
    {
        foreach (char character in word)
        {
            isUpperCase = char.IsUpper(character);
        }

        if (isUpperCase && !upperWords.Contains(word))
        {
            upperWords.Add(word);
        }

    }
    return upperWords;

}