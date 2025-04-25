public class MergeSort
{
    public int[] Sort(int[] array)
    {
        array = recursiveSort(array);
        return array;
    }

    private int[] recursiveSort(int[] array)
    {
        if(array.Length<=1)
        {
            return array;
        }
        int mid = array.Length/2;
        int[] left = sliceArray(array, 0, mid -1);
        int[] right = sliceArray(array,mid, array.Length -1);

        left = recursiveSort(left);
        right = recursiveSort(right);

        return merge(left,right);
    }
    private int[] merge(int[] left, int[] right){
        int[] output = new int[left.Length+right.Length];
        int l=0,r=0,i=0;

        while (l < left.Length && r < right.Length)
        {
            if(left[l] <= right[r])
            {
                output[i] = left[l];
                l++;
            }
            else
            {
                output[i] = right[r];
                r++;
            }
            i++;
        }
        while (l < left.Length)
        {
            output[i] = left[l];
            l++;
            i++;
        }
        while (r < right.Length)
        {
            output[i] = right[r];
            r++;
            i++;
        }
        return output;
    }
    private int[] sliceArray(int[] array, int starting, int ending)
    {
        int[] output = new int[ending -starting +1];
        for (int i=0; i< ending-starting+1; i++)
        {
            output[i] = array[starting+i];
        }
        return output;
    }
}