public class MaxProfit {

    public int GetMaxProfit(int[] Prices){
        
        var PricesKeyValue = Prices.toList().Select((x, i) => new KeyValuePair<int, int>(x, i));

        PricesKeyValue.OrderBy(x => x.Value);

        int maxProfit = 0, previousProfit;
        int i = 0, j = PricesKeyValue.Count - 1;

        while(i != j && maxProfit >= previousProfit)
        {   
            previousProfit = MaxProfit;

            if  (PricesKeyValue.ElementAt(i).Key > PricesKeyValue.ElementAt(j).Key) {
                MaxProfit = PricesKeyValue.ElementAt(i).Value - PricesKeyValue.ElementAt(j).Value;
            }
            if  (PricesKeyValue.ElementAt(i+1).Key > PricesKeyValue.ElementAt(j).Key) {
                MaxProfit = PricesKeyValue.ElementAt(i).Value - PricesKeyValue.ElementAt(j).Value;
            }
            if  (PricesKeyValue.ElementAt(i).Key > PricesKeyValue.ElementAt(j-1).Key) {
                MaxProfit = PricesKeyValue.ElementAt(i).Value - PricesKeyValue.ElementAt(j).Value;
            }

            i++;
            j--;
        }

        return maxProfit;
    }
}