namespace Merge_Sorted_Array
{
    public class Merge
    {
        public void MajorityElement(int[] array1, int[] array2, int n, int m)
        {
            int index1 = m - 1;
            int index2 = n - 1;
            int index = m + n - 1;

            while (index >= 0 && index2 >= 0)
            {
                if (index1 >= 0 && array1[index1] > array2[index2])
                {
                    array1[index] = array1[index1];
                    index1--;
                }
                else
                {
                    array1[index] = array2[index2];
                    index2--;
                }

                index--;
            }
        }
    }
}