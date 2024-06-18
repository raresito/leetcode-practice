namespace LeetCodePractice;

public class p_1002_Find_Common_Characters {
    public IList<string> CommonChars(string[] words)
    {
        int[] frequency = new int[28];
        for (int i = 0; i < words.Length; i++)
        {
            for(int j = 0; j< words[i].Length; j++)
            {
                frequency[words[i][j] - 'a']++;
            }
        }

        IList<string> result = new List<string>();
        
        for(int i = 0; i < frequency.Length; i++)
        {
            for(int j = 0; j < frequency[i] / words.Length; j++)
            {
                char c = (char)('a' + i);
                result.Add(c.ToString());
            }
        }

        return result;
    }

    public p_1002_Find_Common_Characters()
    {
        string[] words = new string[] {"cool","lock","cook"};
        Console.WriteLine(String.Join("\n", CommonChars(words)));
    }
}