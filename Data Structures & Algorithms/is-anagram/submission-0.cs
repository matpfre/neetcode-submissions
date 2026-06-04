public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sCharArray = s.ToCharArray();
        Array.Sort(sCharArray);
        char[] tCharArray = t.ToCharArray();
        Array.Sort(tCharArray);
        if (sCharArray.Length != tCharArray.Length)
        return false;
        for (int i = 0; i < sCharArray.Length; i++) {
            if (sCharArray[i] != tCharArray[i])
                return false;
        }
        return true;
    }
}
