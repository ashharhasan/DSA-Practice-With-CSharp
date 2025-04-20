int[] nums = new int[]{2,3,8,2};

int[] output = new int[nums.Length];
        //int total = nums[0];
        output[0] = 1;
        for (int i=1; i<nums.Length;i++)
        {
            output[i]= output[i-1] * nums[i - 1];
        }
        int post=1;

        for(int i= nums.Length-2;i>-1;i--)
        {
            post = nums[i+1] * post;
            output[i] = output[i] * post;
        }

for(int i=0; i< output.Length;i++)
{
    Console.WriteLine(output[i]);
}