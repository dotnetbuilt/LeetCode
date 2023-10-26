namespace LeetCodeProblemSolutions;

public class SplitStringsBySeparator
{
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) 
    {
        IList<string> newWords = new List<string>();
        for(int i=0;i<words.Count;i++)
        {
            if(words[i].Contains(separator))
            {
                var strArr = words[i].Split(separator);
                for(int j=0;j<strArr.Length;j++)
                {
                    if(strArr[j]!=String.Empty)
                        newWords.Add(strArr[j]);
                }
            }
            else
            {
                newWords.Add(words[i]);
            }
        }   
        return newWords;
    }
}