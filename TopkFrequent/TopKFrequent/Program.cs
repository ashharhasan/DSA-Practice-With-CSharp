// See https://aka.ms/new-console-template for more information
int k=2;
int[] nums = new int[]{-1, 20, -1, 20, -1, 4, 16, 4, 4, 15, 4, 6};
int[] output = TopKFrequent(nums,k);

for(int i=0;i<k;i++)
{
    Console.WriteLine(output[i]);
}

int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> d1 = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!d1.ContainsKey(num))
            {
                d1.Add(num,1);
            }
            else
            d1[num]++;
        }
        

        List<int>[] ArrayOfLists = new List<int>[nums.Length +1];

        foreach(var pair in d1)
        {
            int freq = pair.Value;
            if(ArrayOfLists[freq] == null)
            {
                ArrayOfLists[freq] = new List<int>();
            }
            ArrayOfLists[pair.Value].Add(pair.Key);
        }

        int[] output = new int[k];
        int index=0;
        for (int i= ArrayOfLists.Length-1;i>0;i--)
        {
            if(ArrayOfLists[i] != null)
            {
                output[index] = ArrayOfLists[i][0];
                index++;
                if(index == k)
                {
                    break;
                }
            }
        }

        return output;
    }