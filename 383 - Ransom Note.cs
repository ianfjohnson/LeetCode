//383. Ransom Note
//Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
//Each letter in magazine can only be used once in ransomNote.

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }

        Dictionary<char, int> magazineMap = new Dictionary<char, int>();
        foreach (char c in magazine)
        {
            if (magazineMap.ContainsKey(c))
            {
                magazineMap[c]++;
            }
            else
            {
                magazineMap[c] = 1;
            }
        }

        Dictionary<char, int> ransomNoteMap = new Dictionary<char, int>();
        foreach (char c in ransomNote)
        {
            if (ransomNoteMap.ContainsKey(c))
            {
                ransomNoteMap[c]++;
            }
            else
            {
                ransomNoteMap[c] = 1;
            }
        }

        foreach (char c in ransomNoteMap.Keys)
        {
            if (!magazineMap.ContainsKey(c) || ransomNoteMap[c] > magazineMap[c])
            {
                return false;
            }
        }

        return true;
    }
}