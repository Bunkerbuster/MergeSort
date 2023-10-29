using MergeSortServices.Interfaces;

namespace MergeSortServices
{
    public class MergeSortAlgorithm : IMergeSortAlgorithm
    {
        private readonly IMergeHelper _IMergeHelper;
        public MergeSortAlgorithm
        (
            IMergeHelper _Imergehelper
        )
        {
            _IMergeHelper = _Imergehelper;
        }

        public int[] MergeSortArray(int[] UnsortedArray)
        {
            if (UnsortedArray.Length <= 1)
            {
                return UnsortedArray;
            }

            int middle = UnsortedArray.Length / 2;

            int[] left = new int[middle];
            int[] right = new int[UnsortedArray.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                left[i] = UnsortedArray[i];
            }

            for (int i = middle; i < UnsortedArray.Length; i++)
            {
                right[i - middle] = UnsortedArray[i];
            }

            left = MergeSortArray(left);  
            right = MergeSortArray(right);

            return _IMergeHelper.Merge(left, right, UnsortedArray);
        }

    }
}