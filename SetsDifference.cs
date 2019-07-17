public class SetsDifference {

    public List GetJoinDifference(List list1, list list2){
        return list1.Except(List2).Concat(list2.Except(List1)).ToList();
    }

    public List GetJoinDifference1(List list1, list list2){
        return list1.Concat(list2).Except(List1.Intersect(List2)).ToList();
    }
}