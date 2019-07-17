public class FriendNumbers {

public bool AreFriends(int first, int second){
    return GetDivisorsSum(first) == second && GetDivisorsSum(second) == first;
}

public int GetDivisorsSum(int number){
    sum = 0;

    for (int i=1; i<number; i++) {
        if(number % i == 0){
            sum += i; 
        }
    }
}
}