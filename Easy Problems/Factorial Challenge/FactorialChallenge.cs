int FactorialChallenge(int n) {
    int a = 1;
    if (n==0){
        return 1;
    }
    for(int i = n; i > 0; i--){
        a *= i;
    }
    return a;
}