using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public class LC0088_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var oldLength = m;
            var newLength = m + n;
            Array.Resize(ref nums1, newLength);
            Array.Copy(nums2, 0, nums1, oldLength, nums2.Length);
        }
    }
}
