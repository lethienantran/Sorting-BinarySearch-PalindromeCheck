using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSearchAndTwoPointers
{
    class AllMethods
    {
        //Palindrome Check
        public static bool CheckPalindrome(string userString)
        {
            int i = 0, j = userString.Length - 1;
            while (i < j)
            {
                if (userString[i] != userString[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
        //Sorting Number Ascending Order
        public static void SortingAscendingNum(ref int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for(int j = i+1; j< size; j++)
                {
                    int temp = 0;
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }
        //Sorting Number Descending
        public static void SortingDescendingNum(ref int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    int temp = 0;
                    if (array[i] < array[j])
                    {
                        temp = array[i]; //1 3 5 2 10
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            
        }

        public static void SortingAZ(ref string[] array, int size)
        {
            string temp = "";
            for(int i = 0; i < size; i++)
            {
                array[i] = array[i].ToLower();
            }
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size - 1; j++)
                {
                    if (string.Compare(array[i], array[j]) < 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            
        }
        public static void SortingZA(ref string[] array, int size)
        {
            string temp = "";
            for (int i = 0; i < size; i++)
            {
                array[i] = array[i].ToLower();
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (string.Compare(array[i], array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            
        }
        
        public static int BinaryNumberSearch(int key)
        {
            int[] array = { 0, 10, 25, 1, 3, 5, 20, 14, 100, 24,21,99,52,24};
            SortingAscendingNum(ref array, array.Length);
            int lowBound = 0;
            int highBound = array.Length - 1;
            while(lowBound <= highBound)
            {
                int mid = (lowBound + highBound) / 2;
                if(array[mid] == key)
                {
                    return mid;
                }
                else if (array[mid] > key)
                {
                    highBound = mid - 1;
                }
                else
                {
                    lowBound = mid + 1;
                }
            }
            return -1;
        }
    }
}
