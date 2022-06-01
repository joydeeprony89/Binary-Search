using System;

namespace Binary_Search
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { 5 };
      int target = 5;
    }
  }

  public class Solution
  {
    public int Search(int[] nums, int target)
    {
      int l = 0;
      int r = nums.Length - 1;
      while (l <= r)
      {
        int mid = l + (r - l) / 2;
        int source = nums[mid];
        if (source == target)
        {
          return mid;
        }
        if (source < target)
        {
          l = mid + 1;
        }
        else
        {
          r = mid - 1;
        }
      }
      return -1;
    }
  }
}
