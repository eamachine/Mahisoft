public class SetsDifference {

    public List GetJoinDifference(List list1, list list2){
        var result = new List()

        foreach(var item in list1) {
            if(!list2.Cotains(item)){
                result.add(item);
            }
        }

        
        foreach(var item in list2) {
            if(!list1.Cotains(item)){
                result.add(item);
            }
        }

        return result;

    }
}