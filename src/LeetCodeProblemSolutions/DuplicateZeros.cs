namespace LeetCodeProblemSolutions;

public class DuplicateZeros
{
    public void FindDuplicateZeros(int[] arr) {
        List<int> list = new List<int>();
        for(int i=0;i<arr.Length;i++)
        {
            if (list.Count == arr.Length)
            {
                break;
            }
            if(arr[i]==0)
            {
                list.Add(0);
                list.Add(0);
            }
            else
            {
                list.Add(arr[i]);
            }
        }
        for(int i=0;i<arr.Length;i++)
        {
            arr[i]=list[i];
        }
    }
}