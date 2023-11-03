namespace LeetCodeProblemSolutions;

public class ReverseVowelsOfAString
{
    public string ReverseVowels(string s) 
    {
        char[] vowels = {'a','e','i','o','u','A','I','E','O','U'}; 

        var letters = GetVowels(s, vowels);

        var sArr = GetReversedVowels(s, vowels, letters);

        return string.Join("",sArr);
    }

    private Stack<char> GetVowels(string s, char[] vowels){
        var letters = new Stack<char>();

        for(int i=0;i<s.Length;i++)
        {
            if(vowels.Contains(s[i]))
            {
                letters.Push(s[i]);
            }
        }    

        return letters;
    }

    private List<char> GetReversedVowels(string s,char[] vowels, Stack<char> letters){
        var sArr = s.ToList();

        for(int i=0;i<sArr.Count;i++)
        {
            if(vowels.Contains(sArr[i]))
            {
                sArr[i]=letters.Pop();
            }
        }

        return sArr;
    }
}