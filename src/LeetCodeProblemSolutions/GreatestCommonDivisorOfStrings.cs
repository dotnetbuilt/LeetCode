namespace LeetCodeProblemSolutions;

public class GreatestCommonDivisorOfStrings
{
    public string GcdOfStrings(string str1, string str2) {
        //get length of string has minimum length between 2 strings (str1 & str2)
        int comLen =(int)Math.Min(str1.Length,str2.Length);

        string str3 = "";
        List<string> list = new List<string>();

        //get common substrings of str1 and str2 and add them into list
        for(int i=0;i<comLen;i++)
        {
            str3+=str1[i];
            if(string.Join("",str2.Split(str3)).Length==0 && string.Join("",str1.Split(str3)).Length==0)
                list.Add(str3);
        }

        if(list.Count == 0)
            return "";
        
        return list.Max();
    }
}