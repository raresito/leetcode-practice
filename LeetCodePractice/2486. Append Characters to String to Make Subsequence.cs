namespace LeetCodePractice;

public class p_2486_Append_Characters_to_String_to_Make_Subsequence {
    
    public int AppendCharacters(string s, string t)
    {
        
        int currentLetter = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(currentLetter > t.Length - 1)
            {
                break;
            }
            if (s[i] == t[currentLetter])
            {
                currentLetter++;
            }
        }
        return t.Length - currentLetter;
    }
    
    public p_2486_Append_Characters_to_String_to_Make_Subsequence()
    {
        Console.WriteLine(AppendCharacters("abc", "abcbc"));
    }
}