public class FriendNumbers {

public bool AreFriends(int first, int second){
    return GetDivisorsSum(first) == second && GetDivisorsSum(second) == first;
}

public int GetDivisorsSum(int number){
    sum = 1;

    for (int i=2; i<(number/2 + 1); i++) {
        if(number % i == 0){
            sum += i + number/i; 
        }
    }
}
}