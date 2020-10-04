using System;

using System.Collections.Generic;



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

            //Write code to print the result array here



            Console.WriteLine("Question 5");

            int[] nums1 = { 4, 2, 2, 4 };

            int[] nums2 = { 2, 2 };

            int[] intersect1 = Intersect(nums1, nums2);

            Console.WriteLine("[{0}]", string.Join(", ", intersect1));




            Console.WriteLine("Question 6");

            int[] arr = new int[] { 1, 2, 2, 1, 1, 3 };

            Console.WriteLine(UniqueOccurrences(arr));



            Console.WriteLine("Question 7");

            int[] numbers = { 0, 1, 3, 50, 75 };

            int lower = 0;

            int upper = 99;

//            List<String> ResultList = Ranges(numbers, lower, upper);

            //Write code to print list here



            Console.WriteLine("Question 8");

            string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };

            string[] namesResult = UniqFolderNames(names);

            //Write code to print your result here





        }



        public static void PrintPatternAnyComplexity(int n)



        {

            try

            {

                //Write your code here;

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

                //Write your code here;

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

                //write your code here 

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

                //Write your code here;

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

                //Write Your Code Here

            }

            catch (Exception)

            {



                throw;

            }

            return null;

        }

        public static int[] Intersect(int[] nums1, int[] nums2)

        {

            try

            {

                int i = 0;
                int j = 0;
                int n = nums1.Length;
                int m = nums2.Length;
                Array.Sort(nums1);
                Array.Sort(nums2);
                List<int> outputList = new List<int>();

                while (i < n && j < m)
                {
                    //Comparing elements in the arrays
                    if (nums1[i] > nums2[j])
                    {
                        j++;
                    }

                    else
                    if (nums2[j] > nums1[i])
                    {
                        i++;
                    }
                    else
                    {
                        // Elements are equal, add to list
                        outputList.Add(nums1[i]);
                        i++;
                        j++;
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





        public static bool UniqueOccurrences(int[] arr)

        {

            try

            {

                //Write your code here;

            }

            catch (Exception)

            {



                throw;

            }

            return default;

        }

        public List<String> Ranges(int[] numbers, int lower, int upper)

        {

            try

            {

                //Write Your Code Here

            }

            catch (Exception)

            {



                throw;

            }

            return default;

        }

        public static string[] UniqFolderNames(string[] names)

        {

            try

            {

                //Write Your Code Here

            }

            catch (Exception)

            {



                throw;

            }

            return default;

        }



    }

}




