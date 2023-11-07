namespace LeetCodeProblemSolutions;

public class FindChampionI
{
    public int FindChampion(int[][] grid) {
        
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i=0;i<grid.Length;i++)
        {
            int count = grid[i].Count(a => a==1);
            dict[i] = count;
        }

        return dict.OrderByDescending(a => a.Value).FirstOrDefault().Key;
    }
}