public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var sandwichesOffset = 0;
        var shouldBreak = false;
        var studentsQueue = new Queue<int>(students);
        var counter = 0;

        while(!shouldBreak){
            var st = studentsQueue.Dequeue();
            if (st == sandwiches[sandwichesOffset]) {
                sandwichesOffset++;

                if (sandwichesOffset == sandwiches.Length){
                    return 0;
                }
                counter = 0;
            }
            else {
                if (counter == studentsQueue.Count + 1){
                    return counter;
                }
                studentsQueue.Enqueue(st);
                counter++;
            }
        }

        return counter;
    }
}