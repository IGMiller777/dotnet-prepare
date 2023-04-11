using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education_met.METANIT
{
    internal class MetanitBase
    {

        public static int[] SortNumbers(int[] nums)
        {
            if (nums is null) return new int[] {};
            Array.Sort(nums, 0, nums.Length);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
           
            }
            return nums;
        }
    }


  


}
