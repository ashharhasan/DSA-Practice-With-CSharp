// See https://aka.ms/new-console-template for more information
using System.Text;

string[] input = { "act", "pots", "tops", "cat", "stop", "hat" };
        var grouped = GroupAnagrams(input);

        foreach (var group in grouped)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }

List<List<string>> GroupAnagrams(string[] strs) {
    Dictionary<string, List<string>> d1 = new Dictionary<string, List<string>>();

    foreach(var str in strs)
    {
        string hkey= GetFreqMap(str);
        if(!d1.ContainsKey(hkey))
        {
            d1.Add(hkey,new List<string>());
        }
        d1[hkey].Add(str);
    }
    return d1.Values.ToList();
}

string GetFreqMap(string str)
{
    int[] freq = new int[26];
    foreach(char c in str)
    {
        freq[c - 'a']++;
    }
    return String.Join('#',freq);
}