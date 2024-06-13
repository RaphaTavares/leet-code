public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> pascaltriangle = new();

        for(int i = 0; i < numRows; i++)
        {
            if(i == 0)
            {
                pascaltriangle.Add(new List<int>(){1});
                continue;
            }

            var row = new List<int>(new int[i + 1]);

            row[0] = row[i] = 1;

            for(int j = 1; j < i; j++)
            {
                row[j] = (pascaltriangle[i-1][j -1] + pascaltriangle[i-1][j]);
            }

            pascaltriangle.Add(row);
        }

        return pascaltriangle;
    }
}