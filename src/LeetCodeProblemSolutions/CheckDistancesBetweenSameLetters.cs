namespace LeetCodeProblemSolutions;

public class CheckDistancesBetweenSameLetters
{
    public bool CheckDistances(string s, int[] distance) 
    {
        Dictionary<char,int> dict = new Dictionary<char,int>()
        {
            {'a',0},{'b',1},{'c',2},{'d',3},{'e',4},{'f',5},{'g',6},
            {'h',7},{'i',8},{'j',9},{'k',10},{'l',11},{'m',12},{'n',13},
            {'o',14},{'p',15},{'q',16},{'r',17},{'s',18},{'t',19},{'u',20},
            {'v',21},{'w',22},{'x',23},{'y',24},{'z',25}
        };

        var letters = string.Join("",s.Distinct().OrderBy(x=> x));

        for(int i=0;i<letters.Length;i++)
        {
            int ind = dict[letters[i]];

            if(distance[ind]!= CountLettersBetweenGivenLetterInString(letters[i],s))
                return false;
        }
        return true;
    }

    public int CountLettersBetweenGivenLetterInString(char letter,string word)
    {
        int count = 0;
        int firstIndex = word.IndexOf(letter);
        int secondIndex = word.LastIndexOf(letter);
        for(int i=firstIndex+1;i<secondIndex;i++)
        {
            count++;
        }
        return count;
    }
}