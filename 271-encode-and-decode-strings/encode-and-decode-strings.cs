public class Codec {

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) {
        var encodedStrs = new StringBuilder();

        foreach(var str in strs){
            encodedStrs.Append(str.Length).Append('/').Append(str);
        };

        return encodedStrs.ToString();
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s) {
        var decodedStrs = new List<string>();

        int i = 0;
        while(i < s.Length){
            int slashIndex = s.IndexOf('/', i);
            int length = int.Parse(s.Substring(i, slashIndex - i));

            i = slashIndex + 1;

            decodedStrs.Add(s.Substring(i, length));
            i += length;
        }
        return decodedStrs;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));