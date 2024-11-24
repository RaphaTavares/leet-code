public class MinStack {
    private Stack<int> stack;
    private Stack<int> minNumber;

    public MinStack() {
        stack = new Stack<int>();
        minNumber = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minNumber.Count == 0 || val <= minNumber.Peek()) minNumber.Push(val);
    }
    
    public void Pop() {
        if(stack.Pop() == minNumber.Peek()) minNumber.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minNumber.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */