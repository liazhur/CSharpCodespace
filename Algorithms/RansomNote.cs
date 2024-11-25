public class RansomNote{
    public static void checkMagazine(List<string> magazine, List<string> note)
    {
    if (magazine == null || note == null)
    {
        Console.WriteLine("No");
        return;
    }

    string answer = "Yes";
    Dictionary<string, int> magazineDict = new Dictionary<string, int>();

    // Count words in the magazine
    foreach (string word in magazine)
    {
        if (magazineDict.ContainsKey(word))
        {
            magazineDict[word]++;
        }
        else
        {
            magazineDict[word] = 1;
        }
    }

    // Check words in the note
    foreach (string word in note)
    {
        if (magazineDict.ContainsKey(word) && magazineDict[word] > 0)
        {
            magazineDict[word]--;
        }
        else
        {
            answer = "No";
            break;
        }
    }

    Console.WriteLine(answer);
    }
}