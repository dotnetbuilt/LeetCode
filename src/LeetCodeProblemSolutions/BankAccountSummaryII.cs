namespace LeetCodeProblemSolutions;

public class BankAccountSummaryII
{
    //     select u.name as Name,t.balance as Balance
    //     from users as u
    //     inner join (select account,sum(amount) as balance from transactions
    //     group by account) as t 
    //     on u.account = t.account
    //     where t.balance > 10000;
}