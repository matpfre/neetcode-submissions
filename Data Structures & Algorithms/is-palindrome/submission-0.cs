public class Solution {
    public bool IsPalindrome(string s) {
        char[] sArray = s.ToCharArray();
        string cArray = "";
        foreach(char c in sArray) {
            if(char.IsLetterOrDigit(c))
                cArray += c;
        }
        string cleanString = cArray.ToLower();
        int j = cleanString.Length - 1;
            for(int i = 0; i < j; i++, j--) {
                    if(cleanString[i] != cleanString[j])
                        return false;
            }
        return true;
    }
}
