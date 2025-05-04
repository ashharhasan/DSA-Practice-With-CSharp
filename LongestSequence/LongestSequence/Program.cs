Console.WriteLine(LongestConsecutive(new int[]{2,20,4,10,3,4,5,6}));

int LongestConsecutive(int[] nums) {
        HashSet<int> hset = new HashSet<int>();
        int maxCount=0;

        foreach(int num in nums)
        {
            hset.Add(num);
        }

        foreach(int num in hset)
        {
            if (hset.Contains(num-1))
            {
                continue;
            }
            bool isSeq = true;
            int offset=1;

            while (isSeq)
            {
                if(hset.Contains(num+offset))
                {
                    offset++;
                    continue;
                }
                isSeq=false;
            }
            maxCount = maxCount<offset?offset:maxCount;
        }
        return maxCount;
    }