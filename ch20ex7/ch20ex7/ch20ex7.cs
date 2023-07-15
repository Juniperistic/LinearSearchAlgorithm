using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************************************************************************/
/* Program Name:     Ch20Ex7.cs                                          */
/* Date:             05/02/2022                                        	 */
/* Programmer:       Miranda Morris                                      */
/* Class:            CSCI 234                               	         */
/*                                                        			     */
/* Program Description: The purpose of this program is to use a generic  */
/* method that searches an array using linear-search algorithm.          */
/* Additionally, there is meant to be a test app to ensure the program   */
/* runs properly.                                                        */
/*                                                                       */
/* Input: an array of data in the form int[] arr = { 2,3,4,5}, int x=20; */
/*                                                                       */
/* Output: location of search key in the form "Element is present at     */
/* index 3; or -1	                                                     */
/*                                                                       */
/* Givens: None                                                          */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input Data:                                          */
/*                  int[] arr = { 2, 3, 4, 10, 40 };                     */
/*                  int x = 10;                                          */
/*                  int[] arr = {3, 20 , 10, 40 };                       */
/*                  int x = 20;                                          */
/*                  int[] arr = {1, 15 , 20, 50 };                       */
/*                  int x = 30;                                          */
/*                                                                       */
/* List the Testing Output Data:                                         */
/*                 Element is present at index 3;                        */
/*                 Element is present at index 1;                        */
/*                 Element is not present in array;                      */
/*                                                                       */
/*************************************************************************/


class GFG
{
    public static int search(int[] arr, int x)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    // Driver code
    public static void Main()
    {
        int[] arr = {1, 15 , 20, 50 };
        int x = 30;

        // Function call
        int result = search(arr, x);
        if (result == -1)
            Console.WriteLine(
                "Element is not present in array");
        else
            Console.WriteLine("Element is present at index "
                              + result);
    }
}
