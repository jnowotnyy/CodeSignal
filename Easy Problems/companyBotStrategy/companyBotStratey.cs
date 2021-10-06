double companyBotStrategy(int[][] trainingData) {
    double sum = 0;
    int count = 0;
    foreach(var arr in trainingData){
        if(arr[1] == 1){
            sum += arr[0];
            count++;
        }
    }
    if(sum == 0){
        return 0;
    }
    return sum/count;
}