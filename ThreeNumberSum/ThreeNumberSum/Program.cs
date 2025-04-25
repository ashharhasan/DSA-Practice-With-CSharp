using System.Globalization;
using System.Text;

//List<List<int>> output = ThreeSum(new int[]{-1,0,1,2,-1,-4});
List<List<int>> output = ThreeSum(new int[]{-1,0,1,2,-1,-4,-2,-3,3,0,4});

 List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> output = new List<List<int>>();

        //Array.Sort(nums);

        MergeSort mergeSort = new MergeSort();
        nums = mergeSort.Sort(nums);

        HashSet<string> sset = new HashSet<string>();
        for(int i=0; nums[i]<1;i++)
        {
            int left=i+1;
            int right=nums.Length-1;
            
            while(left<right)
            {
                int sum = nums[i]+nums[left]+nums[right];
                if(sum ==0)
                {
                    if(sset.Contains("" + nums[i] + nums[left] + nums[right]))
                    {
                        left++;
                        continue;
                    }
                    List<int> temp = new List<int>();
                    temp.Add(nums[i]);
                    temp.Add(nums[left]);
                    temp.Add(nums[right]);
                    sset.Add("" + nums[i] + nums[left] + nums[right]);
                    output.Add(temp);
                    left++;
                    right--;
                }
                else if(sum<0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            if(nums[i] == 0 && nums[i+1] == 0)
            {
                break; // for [0,0,0] case
            }
        }
        return output;
    }