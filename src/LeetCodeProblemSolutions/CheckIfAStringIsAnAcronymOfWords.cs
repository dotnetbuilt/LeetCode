namespace LeetCodeProblemSolutions;

public class CheckIfAStringIsAnAcronymOfWords
{
    public bool IsAcronym(IList<string> words, string s) {
        string str = "";
        foreach(var word in words)
        {
            str+=word[0];
        }
        if(str == s)
            return true;
        return false;
    }
}