using System;
using System.Collections.Generic;

namespace Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 5, 2, 1 };
            int target = 1;

            List<string> expressions = Expressions(nums, target);
            Console.WriteLine("Danh sách các biểu thức có thể tạo ra giá trị bằng giá trị target: ");
            foreach (var expression in expressions)
            {
                Console.WriteLine(expression);
            }

        }
        static List<string> Expressions(int[] nums, int target)
        {
            List<string> expressions = new List<string>();
            ExpressionsHelper(nums, target, 0, "", 0, expressions);
            return expressions;
        }
        static void ExpressionsHelper(int[] nums, int target, int index, string expressiton, int eval, List<string> expressions)
        {
            if (index == nums.Length)
            {
                if (eval == target)
                {
                    expressions.Add(expressiton);
                }
                return;
            }

            ExpressionsHelper (nums, target, index + 1, expressiton + "+" + nums[index], eval + nums[index], expressions);
            ExpressionsHelper (nums, target, index + 1, expressiton + "-" + nums[index], eval - nums[index], expressions);
        }
    }
}
