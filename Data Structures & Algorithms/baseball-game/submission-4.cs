public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();

        foreach(var op in operations)
        {
            switch(op){
                case string when int.TryParse(op, out var num):
                stack.Push(num);
                break;
                case "C":
                stack.Pop();
                break;
                case "D":
                stack.Push(stack.Peek() * 2);
                break;
                case "+":
                var top = stack.Pop();
                var second = stack.Peek();
                stack.Push(top);
                stack.Push(top + second);
                break;
            }
        }

        return stack.Sum();
    }
}