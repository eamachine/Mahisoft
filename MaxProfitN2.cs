public class MaxProfit {

    public int GetMaxProfit(int[] Prices){
        int maxProfit = 0;

        for (int i=0; i<Prices.Length - 1; i++) {
            for (int j=; j<Prices.Length; j++) {
                maxProfit = Math.Max(maxProfit, Prices[j] - Prices[i]); 
            }    
        }
        return maxProfit;
    }
}