using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = {101, 102, 103, 104, 105, 106 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                /* validating input parameters*/
                if(n!=nums.Length/2 || nums.Length==0 || n<1)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                int[] arr = new int[nums.Length];
                int j = 0;
                int k = n;
                /*Incrementing i by 2 for adding two elements in each iteration. 
                 * j is incremented for x's and k is incremented for y's */
                for (int i = 0; i < 2 * n; i += 2)
                {
                    arr[i] = nums[j];
                    arr[i + 1] = nums[k];
                    j++;
                    k++;
                }
                //Printing new array as x1y1,x2y2..
                foreach (var b in arr)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int cnt = 0, k = 0;
                /*Iterate through the array and when a non-zero element encounters, 
                 * position it from start of the array. Also get the count of zeros*/
                for (int i = 0; i < ar2.Length; i++)
                {
                    if (ar2[i] == 0)
                        cnt++;
                    else
                    {
                        ar2[k] = ar2[i];
                        k++;
                    }
                }
                //Printing 'cnt' number of Zeroes at the end of the array
                for (int i = ar2.Length - cnt; i < ar2.Length; i++)
                {
                    ar2[i] = 0;
                }
                //Printing output array after moving all the Zeroes to the end
                foreach (var b in ar2)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();


            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                /* validating input parameters*/
                if (nums.Length == 0 )
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                //Initialized the dictionary to add elements from nums array
                Dictionary<int, int> pairs = new Dictionary<int, int>();
                int cnt = 1;
                int sum = 0;
                //loop iterates through dictionary     
                for (int i = 0; i < nums.Length; i++)
                {
                    //if element already exists in array increase the value by 1 or 
                    //else add the element to the dictionary
                    if (pairs.ContainsKey(nums[i]))
                    {
                        pairs[nums[i]]++;
                    }
                    //inserts that particular element as key and value as 1
                    else
                    {
                        pairs.Add(nums[i], cnt);
                    }
                }
                //Calculating the total no. of cool pairs
                //cool pairs per element are n*(n-1)/2
                // adding above numbers to sum 
                foreach (var b in pairs)
                {
                    int n = b.Value;
                    sum += n * (n - 1) / 2;
                }
                //Printing the sum of all cool pairs
                Console.WriteLine(sum);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                int x = 0, y = 0;
                //Creating a dictionary to store difference between target and present element value
                Dictionary<int, int> diff = new Dictionary<int, int>();
                for(int i = 0; i < nums.Length; i++)
                {
                    //iterating through array, adds difference between target and current element if not already present
                    //adds position of the current element as value
                    //if element is present we found the pair. present i and value in dictionary is solution
                    if (diff.ContainsKey(nums[i]))
                    {
                        x = diff[nums[i]];
                        y = i;
                        Console.WriteLine("[" + x + "," + y + "]");
                    }
                    else
                    {
                        diff.Add(target - nums[i], i);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                /* validating input parameters*/
                if (indices.Length != s.Length)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                //intitializing the new array for shuffled string
                char[] newStr = new char[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    //placing s[i] in new array newStr with index as indices[i]
                    newStr[indices[i]] = s[i];
                }
                //priting output char array
                foreach (var x in newStr)
                {
                    Console.Write(x);
                }
                Console.WriteLine();

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                // If the length of the two strings are different then they are not isomorphic
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                // Create a dictionary to compare the similarity of the characters from both the input strings
                Dictionary<char, char> dict = new Dictionary<char, char>();
                // Use the loop to traverse through both the strings to compare the similarity of the strings
                for (int i = 0; i < s1.Length; i++)
                {
                    // If the dictionary contains the key then we compare it with the corresponding value with the character at the same position from the second string
                    if (dict.ContainsKey(s1[i]))
                    {
                        // If the dictionary value from first string doesn't match with the second string's character at the corresponding position then we retrun false 
                        if (dict[s1[i]] != s2[i])
                        {
                            return false;
                        }
                    }
                    // If the dictionary does not contain the first string character at that corresponding position we add it to the dictionary
                    else
                    {
                        dict.Add(s1[i], s2[i]);
                    }
                }
                // Create a hash set to store all the dictionary values or the frequency of the dictionary key's in it 
                HashSet<char> set = new HashSet<char>(dict.Values);
                // If the total count of the values in the hash set and the dictionary values are same then it is isomorphic and we return true
                if (set.Count == dict.Values.Count)
                {
                    return true;
                }
                // In all other cases we return false
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                Dictionary<int, List<int>> score = new Dictionary<int, List<int>>();
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    //checks for ContainsKey(ID), if found then insert score in value list
                    if (score.ContainsKey(items[i, 0]))
                    {
                        score[items[i, 0]].Add((items[i, 1]));
                    }
                    //if not found, adds ID and score from items list to dictionary 
                    else
                    {
                        score.Add(items[i, 0], new List<int>());
                        score[items[i, 0]].Add((items[i, 1]));
                    }
                }
                //TraVersing through dictionary
                foreach (var s in score)
                {
                    //sorting the values of dictionary i.e, list of marks
                    s.Value.Sort();
                    //reversing so that we get descending order
                    s.Value.Reverse();
                }
                foreach (var b in score)
                {
                    int sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        //adding first 5 max marks for every student
                        sum += b.Value[i];
                    }
                    //putting that sum in value(1) in disctionary list
                    b.Value[1] = sum;
                }
                Console.Write("[");
                foreach (var b in score)
                {
                    //printing average of the sum
                    Console.Write("[{0},{1}]", b.Key, b.Value[1] / 5);
                }
                Console.Write("]");
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                int sum = 0;
                int k = n;
                Dictionary<int, int> dict = new Dictionary<int, int>();
                //the loop runs until n=sum=1
                while (n != 1)
                {
                    //squaring digit and adding to the sum
                    while (n != 0)
                    {
                        sum += (n % 10) * (n % 10);
                        n /= 10;

                    }
                    n = sum;
                    //if sum is in dict or the starting number=sum then automatically it is not Happy number, it keeps on continuning 
                    if (dict.ContainsKey(sum) || sum ==k)
                        return false;
                    dict.Add(sum, 1);
                    sum = 0;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                //max for profit
                int max = 0;
                //this is used for initializing min price of stock on that particular day.
                int buy_stock = prices[0];
                for (int i = 1; i < prices.Length; i++)
                {
                    //taking min of buy_stock and prices[i]
                    buy_stock = Math.Min(buy_stock, prices[i]);
                    //taking max of profit between earlier max and (prices[i] - buy_stock)
                    max = Math.Max(max, (prices[i] - buy_stock));
                }
                return max;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                int m = 1, n = 2;
                int ways = 0;
                //if steps==1, we will be having only 1 possible way to climb
                if (steps == 1)
                    Console.WriteLine(1);
                //if steps==2, we will be having only 2 possible ways to climb
                if (steps == 2)
                    Console.WriteLine(2);
                else
                {
                    //adding preceeding 2 elements will fetch the no. of possible ways
                    for (int i = 2; i < steps; i++)
                    {
                        ways = m + n;
                        m = n;
                        n = ways;
                    }
                }
                //printing no. of ways as output
                Console.WriteLine(ways);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

