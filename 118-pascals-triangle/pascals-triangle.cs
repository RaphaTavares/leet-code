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

            var row = new List<int>();

            for(int j = 0; j <= i; j++)
            {
                if(j == 0 || j == i)
                {
                    row.Add(1);
                    continue;
                }

                row.Add(pascaltriangle[i-1][j] + pascaltriangle[i-1][j-1]);
            }

            pascaltriangle.Add(row);
        }

        return pascaltriangle;
    }
}