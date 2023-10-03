//1672. Richest Customer Wealth
//You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the ith customer has in the jth bank. Return the wealth that the richest customer has.

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;

        foreach (int[] account in accounts)
        {
            int accountWealth = 0;

            foreach (int value in account)
            {
                accountWealth += value;
            }

            if (accountWealth > maxWealth)
            {
                maxWealth = accountWealth;
            }
        }

        return maxWealth;
    }
}