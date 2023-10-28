namespace LeetCodeProblemSolutions;

public class ShortestDistanceToTargetStringInACircularArray
{
    public int ClosetTarget(string[] words, string target, int startIndex) 
    {
        if (!words.Contains(target))
            return -1;

        var targetInds = GetTargetIndexes(target,words);
        var result = GetShortestPath(startIndex, targetInds, words.Length);

        return result;
    }

    public IList<int> GetTargetIndexes(string target,string[] words)
    {
        IList<int> targetIndexes = new List<int>();

        for(int i=0;i<words.Length;i++)
        {
            if(words[i] == target)
                targetIndexes.Add(i);
        }

        return targetIndexes;
    }

    public int GetShortestPath(int startInd, IList<int> targetInds, int wordsLength)
    {
        IList<int> paths = new List<int>();

        foreach(var ind in targetInds)
        {
            paths.Add(Math.Abs(ind-startInd));
        }

        int n = wordsLength;

        foreach(var ind in targetInds)
        {
            paths.Add(Math.Abs(startInd - (n-1))+1+ind);
        }

        foreach(var ind in targetInds)
        {
            paths.Add(Math.Abs(startInd - 0)+1+(n-1 - ind));
        }
        
        return paths.Min();
    }
}