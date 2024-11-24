public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();

        for(int i = 0; i < operations.Length; i++){
            switch(operations[i]){
                case "+":
                    var numberOne = stack.Pop();
                    var numberTwo = stack.Peek();
                    var tempResult = numberOne + numberTwo;
                    stack.Push(numberOne);
                    stack.Push(tempResult);
                    break;
                case "D":
                    stack.Push(stack.Peek() * 2);
                    break;
                case "C":
                    stack.Pop();
                    break;
                default:
                    stack.Push(int.Parse(operations[i]));
                    break;
            }
        }

        return stack.Sum();
    }
}