public class MyStack {
    private List<int> _stack;
    public int Count { get; set; }

    public MyStack() {
        _stack = new List<int>();
    }
    
    public void Push(int x) {
        _stack.Add(x);
        Count++;
    }
    
    public int Pop() {
        if (Empty()){
            throw new Exception("Empty stack");
        }
        var tmp = _stack[Count - 1];
        _stack.RemoveAt(Count - 1);
        Count--;
        return tmp;
    }
    
    public int Top() {
        if (Empty()){
            throw new Exception("Empty stack");
        }
        return _stack[Count - 1];
    }
    
    public bool Empty() {
        return Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */