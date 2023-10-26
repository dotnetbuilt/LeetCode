namespace LeetCodeProblemSolutions;

public class UniqueEmailAddresses
{
    public int NumUniqueEmails(string[] emails) {
        IList<string> emails2 = emails.ToList();
        for(var i=0;i<emails2.Count;i++)
        {
            var gmail = emails2[i].Split('@');
            var str = String.Empty;
            foreach(var part in gmail[0])
            {
                if(part == '+')
                    break;
                if(part != '.')
                    str+=part;
            }
            gmail[0]=str;
            emails2[i] =gmail[0] +'@'+ gmail[1]; 
        }
        emails2 = emails2.Distinct().ToList();

        return emails2.Count;
    }
}