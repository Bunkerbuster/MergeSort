using MergeSortServices.Interfaces;

namespace MergeSortServices.Helpers
{
    public class MergeHelper : IMergeHelper
    {
        public int[] Merge(int[] left, int[] right, int[] arr)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                result[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                result[k] = right[j];
                j++;
                k++;
            }

            return result;
        }
    }
}
