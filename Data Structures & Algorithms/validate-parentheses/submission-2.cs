public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s) || s.Length == 1){
            return false;
        }
        var stack = new Stack<char>();
        var openBrackets = new HashSet<char>{ '(', '{', '[' };
        var map = new Dictionary<char, char>
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        foreach(var ch in s){
            if (openBrackets.Contains(ch)){
                stack.Push(ch);
            }
            
            if (map.ContainsKey(ch)){
                if (stack.Count == 0){
                    return false;
                }
                if (map[ch] != stack.Pop())
                {
                    return false;
                }
            }
        }

        if (stack.Count > 0){
            return false;
        }

        return true;
    }
}
