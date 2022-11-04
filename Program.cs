using System;
using System.Collections.Generic;

namespace Codechallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array");
            int length = int.Parse(Console.ReadLine());
            int[] nums = new int[length];
            Console.WriteLine("Enter the number to be searched");
            int original = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element of the array");
            for (int i = 0; i < length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            
            int result = OutPut(nums, original);
            Console.WriteLine(result);
        }

        public static int OutPut(int[] a, int b)
        {
            List<int> list = new List<int>();
            list.AddRange(a);
            int firstSearch = 0;
                int secondSearch = 0;
                int thirdSearch = 0;
                int fourthSearch = 0;
                int fifthSearch = 0;
            foreach(var item in list)
            {
                
                if (item != b)
                {
                    return b;
                }
                else
                {
                    firstSearch = b * 2;
                    if(list.Contains(firstSearch))
                    {
                        secondSearch = firstSearch * 2;
                        if(list.Contains(secondSearch))
                        {
                            thirdSearch = secondSearch * 2;
                            if (list.Contains(thirdSearch))
                            {
                                fourthSearch = thirdSearch * 2;
                                 if (list.Contains(fourthSearch))
                                {
                                    return fifthSearch = fourthSearch * 2;
                                }
                                else
                                {
                                    return fourthSearch;
                                }
                            }
                            else
                            {
                                return thirdSearch;
                            }
                        }
                        else
                        {
                            return secondSearch;
                        }
                    }
                    else
                    {
                        return firstSearch;
                    }
                }
            }
            return fifthSearch ;

        }
    }
}
