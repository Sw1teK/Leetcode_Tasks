using System;

namespace BestTimetoBuyandSellStock121
{
    public class BestTimeToBuy
    {
        public static int ProfitBuy(int[] prices)
        {
            int maxProfit = 0;
            int buy = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (maxProfit < prices[i] - buy)
                {
                    maxProfit = prices[i] - buy;
                }

                if (buy > prices[i])
                {
                    buy = prices[i];
                }
            }

            return maxProfit;
        }
        
    }
}