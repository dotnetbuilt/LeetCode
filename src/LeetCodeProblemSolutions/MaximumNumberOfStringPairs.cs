namespace LeetCodeProblemSolutions;

public class MaximumNumberOfStringPairs
{
    public int FindMaximumNumberOfStringPairs(string[] words) 
    {
        int count = 0;
        for(int i=0;i<words.Length-1;i++)
        {
            for(int j=i+1;j<words.Length;j++)
            {
                if(CheckStringsEqual(words[i],words[j])==true)
                {
                    words[i] = Guid.NewGuid().ToString();
                    words[j] = Guid.NewGuid().ToString();
                    count++;
                }
            }
        }

        return count;
    }

    public bool CheckStringsEqual(string str1,string str2)
    {
        var str1CharArr = str1.ToCharArray();
        Array.Reverse(str1CharArr);
        var str2CharArr = str2.ToCharArray();
        return str1CharArr.SequenceEqual(str2CharArr);
    }
}