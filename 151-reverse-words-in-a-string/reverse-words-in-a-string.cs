public class Solution
{
    public string ReverseWords(string s)
    {
        int start = s.Length - 1;
        int end = s.Length - 1;
        StringBuilder result = new StringBuilder();

        while (start >= 0)
        {
            // Skip spaces
            while (start >= 0 && s[start] == ' ')
            {
                start--;
                end--;
            }

            // Find the start of the word
            while (start >= 0 && s[start] != ' ')
            {
                start--;
            }

            // Append the word
            if (end >= 0)
            {
                if (result.Length > 0)
                {
                    result.Append(' ');
                }
                result.Append(s.Substring(start + 1, end - start));
            }

            // Move the end to the start of the next word
            end = start;
        }

        return result.ToString();
    }
}
