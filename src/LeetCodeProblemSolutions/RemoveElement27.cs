namespace LeetCodeProblemSolutions;

public class RemoveElement27
{
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        
        //declare all numbers are equal to val to 51
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==val)
            {
                nums[i]=51;
                count++;
            }
        }

        //replace all 51s with others
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==51)
                for(int j=i;j<nums.Length;j++)
                {
                    if(i==j) continue;
                    
                    if(nums[j]!=51)
                    {
                        nums[i] = nums[j];
                        nums[j] = 51;
                        break;
                    }
                }
        }

        return nums.Length-count;
    }
}