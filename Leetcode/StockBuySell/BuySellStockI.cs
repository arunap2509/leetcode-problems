namespace Leetcode.StockBuySell;

public class BuySellStockI
{
    public static int MaxProfit(int[] prices)
    {
        var min = int.MaxValue;
        var profit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            profit = Math.Max(profit, prices[i] - min);
        }

        return profit;
    }
}

