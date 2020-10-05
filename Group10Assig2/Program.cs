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

        public static void PrintPatternAnyComplexity(int n)
        {
            try
            {

                //Write your code here; Q1

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

                //Write your code here; Q1

            }

            catch (Exception)
            {

                throw;

            }
        }

        public static int LongestSubSeq(int[] nums)
        {
            try
            {

                //write your code here Q2

            }

            catch (Exception)
            {

                throw;

            }

            return 0;
        }

        public static void PrintTwoParts(int[] array2)
        {
            try
            {

                //Write your code here; Q3

            }

            catch (Exception)
            {

                throw;

            }
        }

        public static int[] SortedSquares(int[] A)
        {
            try
            {

                //Write Your Code Here; Q4

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
    }
}




