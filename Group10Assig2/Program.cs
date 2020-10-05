using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Assignment2_Fall2020

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int n = 7;
            PrintPatternAnyComplexity(n);
            PrintPatternLinearComplexity(n);


            Console.WriteLine("Question 2");
            int[] array1 = new int[] { 1, 3, 5, 4, 7 };
            int result = LongestSubSeq(array1);
            Console.WriteLine(result);


            Console.WriteLine("Question 3");
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 5 };
            PrintTwoParts(array2);


            Console.WriteLine("Question 4");
            int[] array3 = new int[] { -4, -1, 0, 3, 10 };
            int[] result2 = SortedSquares(array3);
            //Write code to print the result array here:
            //int i;
            //for (i=0;i<array3.Length;i++)
            //{
              //Console.Write(array3[i]+",");
            //}
            //Console.Write("\n");

            Console.WriteLine("Question 5");
            int[] nums1 = { 4, 2, 2, 4 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect(nums1, nums2);
            //Write code to print the result array here:
            Console.WriteLine("[{0}]", string.Join(", ", intersect1));


            Console.WriteLine("Question 6");
            int[] arr = new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            Console.WriteLine(UniqueOccurrences(arr));


            Console.WriteLine("Question 7");
            int[] numbers = { 0, 1, 3, 50, 75 };
            int lower = 0;
            int upper = 99;
            List<String> ResultList = Ranges(numbers, lower, upper);
            //Write code to print the result array here:
            Console.Write("[");
            bool firstRun = true;
            for (int i = 0; i < ResultList.Count(); i++)
            {
                if (!firstRun) {
                    Console.Write(",");
                }
                else
                {
                    firstRun = false;
                }
                Console.Write("\"" + ResultList[i] + "\"");
            }
            Console.WriteLine("]");


            Console.WriteLine("Question 8");
            string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            string[] namesResult = UniqFolderNames(names);
            //Write code to print the result array here:
            Console.Write("[");
            firstRun = true;
            for (int i = 0; i < namesResult.Length; i++)
            {
                if (!firstRun)
                {
                    Console.Write(",");
                }
                else
                {
                    firstRun = false;
                }
                Console.Write("\"" + namesResult[i] + "\"");
            }
            Console.WriteLine("]");
        }

        //QUESTION 1
        public static void PrintPatternAnyComplexity(int n)

        {
            try
            {
                int i, j;
                //We will first declare the integers I and J since we are going to use them later in our for loop
                Console.WriteLine("How many rows do you need in your pyramid?:");
                n = Convert.ToInt32(Console.ReadLine());
                //Now getting the input from the user
                for (i = 1; i <= n; i++)
                //The way that I have decided to build this pyramid is through matrix notation. I here will represent the row
                //whereas J will represent the column. So this loop is designed in a way that it will first deal with the
                //rows and then with the columns.
                {
                    for (j = 1; j <= i; j++)
                    //2n-1 is used here because that is the odd number progression. In the 2nd row we need 3 stars for example.
                    //once J increases more than 2n-1, the loop returns to the previous line. 
                    //{
                    //if (j >= n - (i - 1) && j <= n + (i - 1))
                    //    //This line is important for the pyramid to be center aligned.
                    {
                        Console.Write("*");

                    }
                    Console.Write("\n");//When the program is done printing the stars in a row, it is instructed 
                                        //to start printing from the new line.
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void PrintPatternLinearComplexity(int n)

        {
            try
            {
                int i;
                Console.WriteLine("How many rows do you need in your pyramid?:");//asking the user for number of rows
                n = Convert.ToInt32(Console.ReadLine());//conerting it to int
                String s = "";//starting value for string
                for (i = 1; i <= n; i++)
                {
                    s += "*";//every line, we add an additional star to print
                    Console.WriteLine(s);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //QUESTION 2
        public static int LongestSubSeq(int[] nums)
        {
            try
            {
                // 'max' to store the length of longest increasing subarray
                // 'len' to store the lengths of longest increasing subarray at diiferent instants of time 
                int max = 1, len = 1;
                int n = nums.Length;
                // traverse the array from the 2nd element
                for (int i = 1; i < n; i++)
                {

                    // if current element if greater than previous element, then this element
                    // helps in building up the previous increasing subarray encountered so far 
                    if (nums[i] > nums[i - 1])
                        len++;
                    else
                    {
                        // check if 'max' length is less than the length of the current increasing subarray. If true, than update 'max'
                        if (max < len)
                            max = len;

                        // reset 'len' to 1 as from this
                        // element again the length of the
                        // new increasing subarray is being
                        // calculated
                        len = 1;
                    }
                }

                // comparing the length of the last
                // increasing subarray with 'max'
                if (max < len)
                    max = len;

                // required maximum length
                return max;
                Console.Write("\n");
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }

        //QUESTION 3
        public static void PrintTwoParts(int[] array2)
        {
            try
            {
                {
                    int n;
                    n = array2.Length;
                    int splitPoint = findSplitPoint(array2);

                    if (splitPoint == -1 || splitPoint == n)
                    {
                        Console.Write("Not Possible");
                        return;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (splitPoint == i)
                            Console.WriteLine();

                        Console.Write(array2[i] + " ");
                    }
                    Console.WriteLine("\n");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //QUESTION 4
        public static int[] SortedSquares(int[] A)
        {
            try
            {
                int i, len;
                int[] B;
                len = A.Length;
                for (i = 0; i < len; i++)
                {
                    A[i] = A[i] * A[i];//finding the square value of each element
                }
                Array.Sort(A);//now sorting that array
                for (i = 0; i < len; i++)
                {
                    Console.Write(A[i] + " ");//writing every element
                }
                Console.Write("\n");
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }

        //QUESTION 5
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            try
            {
                int a = 0;
                int b = 0;
                int n = nums1.Length;
                int m = nums2.Length;
                Array.Sort(nums1);
                Array.Sort(nums2);
                List<int> outputList = new List<int>();

                while (a < n && b < m)
                {
                    //Comparing elements in the arrays
                    if (nums1[a] > nums2[b])
                    {
                        b++;
                    }

                    else
                    if (nums2[b] > nums1[a])
                    {
                        a++;
                    }
                    else
                    {
                        // Elements are equal, add to list
                        outputList.Add(nums1[a]);
                        a++;
                        b++;
                    }
                }
                return outputList.ToArray();
            }

            catch
            {
                throw;
            }
//            return new int[] { };
        }

        //QUESTION 6
        public static bool UniqueOccurrences(int[] arr)
        {
            try
            {
                bool unique = true; //is the value unique
                int[] distinctArr = arr.Distinct().ToArray(); //create an array of only distinct values
                int m = arr.Length; //length of the orig array
                int n = distinctArr.Length; //length of the new array with only distinct values
                int i = 0; //counter for outer loop
                int j = 0; //counter for inner loop
                int res = 0; //result of count occurance
                int[] resArray = new int[distinctArr.Length]; //make a results array, smae length as the distinct array

                //loop through the disctint array and count the occurences of each item in the original array
                for (i = 0; i < n; i++)
                {
                    for(j = 0; j < m; j++)
                    {
                        if(arr[j] == distinctArr[i])
                        {
                            res++;
                        }

                    }
                    resArray[i] = res;
                    res = 0;
                }

                if (resArray.Length != resArray.Distinct().ToArray().Length)
                {
                    unique = false;
                }

                return unique;

            }

            catch (Exception)
            {
                throw;
            }
            return default;
        }

        //QUESTION 7 - ADDED "STATIC" to fix error in driver code
        public static List<String> Ranges(int[] numbers, int lower, int upper)
        {
            try
            {
                int n = numbers.Length;
                List<string> deltaRanges = new List<string>();
                int i = 0; //counter

                // if numbers is blank, return a blank list
                if (n == 0)
                {
                    deltaRanges.Add(RangeLabel(lower, upper));
                    return deltaRanges;
                }
                    

                //check for missing lower edge range
                if (numbers[0] > lower)
                {
                    deltaRanges.Add(RangeLabel(lower,numbers[0]-1));
                }

                //now look for the in-between missing ranges
                for (i = 1; i < n; i++)
                {
                    if (numbers[i] - numbers[i-1] > 1)
                    {
                        deltaRanges.Add(RangeLabel(numbers[i-1] + 1, numbers[i] - 1));
                    }
                }
             
                //check for missing upper range
                if (upper - numbers[n-1] > 0)
                {
                    deltaRanges.Add(RangeLabel(numbers[n-1]+1,upper));
                }

                return deltaRanges;
            }

            catch (Exception)
            {
                throw;
            }
            return default;
        }

        // create the range label 
        public static string RangeLabel(int lower, int upper)
        {
            if (lower != upper)
            {
                return lower.ToString() + "->" + upper.ToString();
            }
            else
            {
                return upper.ToString();
            }
        }

        //QUESTION 8
        public static string[] UniqFolderNames(string[] names)
        {
            try
            {
                string[] resArr = new string[names.Length]; //array to store the fixed names
                Dictionary<string, int> MyDictionary = new Dictionary<string, int>(); //to store names and the count
                int i; //counter for loop
                int fileNum = 0; //to hold the possible next value for the number part of the name

                for (i = 0; i < names.Length; i++)
                {
                    string newName = names[i];

                    if (!MyDictionary.ContainsKey(newName)) // if the dictionary doesn't already have this name, just add it and move on
                    {
                        MyDictionary.Add(newName, 0);
                    }
                    else //this means there's a match and we need to figure out the next number
                    {
                        fileNum = MyDictionary[newName] + 1; //get the current number in the dict and add one
                        newName = names[i] + "(" + fileNum + ")"; //build the new name with this number

                        while (MyDictionary.ContainsKey(newName))  //but we need to make sure this new name isn't already in the dict also
                        {
                            fileNum++;  //if it is, go to the next possible number
                            newName = names[i] + "(" + fileNum + ")";  //and rebuild the name again
                        }

                        MyDictionary[names[i]] = fileNum;  //update the dict with the new number
                        MyDictionary.Add(newName, fileNum); //and add the new name to the dict
                    }

                    resArr[i] = newName; //store the corrected name in the result array
                }

                return resArr;
               
            }

            catch (Exception)
            {
                throw;
            }

            return default;
        }

        //ADDITIONAL Q3 CONTENT
        static int findSplitPoint(int[] arr)
        {
            int n;
            n = arr.Length;
            int leftSum = 0;

            // traverse array element
            for (int i = 0; i < n; i++)
            {

                // add current element to left Sum
                leftSum += arr[i];

                // find sum of rest array
                // elements (rightSum)
                int rightSum = 0;

                for (int j = i + 1; j < n; j++)
                    rightSum += arr[j];

                // split point index
                if (leftSum == rightSum)
                    return i + 1;
            }

            // if it is not possible to 
            // split array into two parts
            return -1;
        }
    }
}




