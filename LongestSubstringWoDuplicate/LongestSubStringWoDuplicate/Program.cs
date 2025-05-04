
Console.WriteLine(LengthOfLongestSubstring("thequickbrownfoxjumpsoverthelazydogthequickbrownfxjumpsoverthelazydog"));


int LengthOfLongestSubstring(string s)
{
    Dictionary<char, int> map = new Dictionary<char, int>();
    int currentCount;
    int left = 0, right = 0, maxCount = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (map.ContainsKey(s[i]))
        {
            if (map[s[i]] < left)
            {
                //if character is found but before left then just update the index and continue
                map[s[i]] = i;
                right++;
                continue;
            }
            //calculate the max
            currentCount = right - left;
            maxCount = maxCount > currentCount ? maxCount : currentCount;

            //move left to the index plus 1
            left = map[s[i]] + 1;
            //update the index in map
            map[s[i]] = i;


            //move right ++
            right++;
        }
        else
        {
            if (!map.ContainsKey(s[i]))
                //Add in map
                map.Add(s[i], i);
            //increase right
            right++;
        }
    }
    currentCount = right - left;
    maxCount = maxCount > currentCount ? maxCount : currentCount;
    return maxCount;
}