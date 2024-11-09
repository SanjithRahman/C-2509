using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace String_Lab
{
    internal class Program
    {
        //buble sort
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;  
            }
            return -1;  
        }
        static int BinarySearch(int[] array, int target)
        {
            int left = 0; 
            int right = array.Length - 1; 
            while (left <= right)
            {
                int mid = left + (right - left) / 2; 

             
                if (array[mid] == target)
                    return mid; 

                
                if (array[mid] < target)
                    left = mid + 1;

               
                else
                    right = mid - 1;
            }

            return -1; 
        }
        public static double FindMedian(int[] arr)
        {
            Array.Sort(arr);
            int mid = arr.Length / 2;
            return arr.Length % 2 != 0 ? arr[mid] : (arr[mid - 1] + arr[mid]) / 2.0;
        }

        public static int FindMode(int[] arr)
        {
            Dictionary <int,int> dict1 = new Dictionary<int,int>();
            int mode = arr[0];
            int maxCount = 0;

            foreach (int i in arr) {
                if (dict1.ContainsKey(i))
                {
                    dict1[i]++;
                }
                else
                {
                    dict1[i] = 1;
                }

                if (dict1[i] > maxCount)
                {
                    maxCount= dict1[i];
                    mode = i;
                }
            }
            return mode;
        }

        static bool CheckIfDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }



        static void Main(string[] args)
        {
            ////1.matrix addition,multiplication
            ////
            //Console.WriteLine("Enter  rows of matrix A:");
            //int row1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter  columns of matrix A:");
            //int cols1 = int.Parse(Console.ReadLine());
            ////creating a 2-d array

            //int[,] matrixA = new int[row1, cols1];


            //Console.WriteLine("Enter elements of Matrix A:");
            //for (int i = 0; i < row1; i++)
            //{
            //    for (int j = 0; j < cols1; j++)
            //    {

            //        matrixA[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Enter  rows of matrix B:");
            //int row2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter  columnsof matrix B:");
            //int cols2 = int.Parse(Console.ReadLine());
            ////creating a 2-d array

            //int[,] matrixB = new int[row2, cols2];

            //Console.WriteLine("Enter elements of Matrix B:");
            //for (int i = 0; i < row2; i++)
            //{
            //    for (int j = 0; j < cols2; j++)
            //    {

            //        matrixB[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int[,] resultMatrix = new int[row2, cols1];

            ////addition
            //for (int i = 0; i < row2; i++)
            //{
            //    for (int j = 0; j < cols1; j++)
            //    {
            //        resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            //    }
            //}

            //Console.WriteLine("Result of Matrix Addition:");
            //for (int i = 0; i < row1; i++)
            //{
            //    for (int j = 0; j < cols1; j++)
            //    {
            //        Console.Write(resultMatrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            ////creating new array for multiplication
            //int[,] multiplicationResult = new int[row2, cols1];
            ////multiplication
            //if (cols1 == row2)
            //{
            //    for (int i = 0; i < row2; i++)
            //    {
            //        for (int j = 0; j < cols1; j++)
            //        {
            //            multiplicationResult[i, j] = 0;
            //            for (int k = 0; k < cols1; k++)
            //            {
            //                multiplicationResult[i, j] += matrixA[i, k] * matrixB[k, j];
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Cannot multiply these matrices.");
            //}
            //Console.WriteLine("Result of Matrix Multiplication:");
            //for (int i = 0; i < row2; i++)
            //{
            //    for (int j = 0; j < cols1; j++)
            //    {
            //        Console.Write(multiplicationResult[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("printing Result of multiplication in transpose");
            //int[,] transposeMatrix = new int[cols1, row2];
            //for (int i = 0; i < row2; i++)
            //{
            //    for (int j = 0; j < cols1; j++)
            //    {
            //        transposeMatrix[j, i] = multiplicationResult[i, j];

            //    }

            //}
            //for (int i = 0; i < row2; i++)
            //{
            //    for (int j = 0; j < cols1; j++)
            //    {
            //        Console.Write(transposeMatrix[i, j] + " ");


            //    }
            //    Console.WriteLine();

            //}

            //2nd 
            //int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            //BubbleSort(array);
            //foreach (int item in array)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //int[] array2 = { 5, 89, 23, 99, 2, 890, 57, 1 };
            //InsertionSort(array2);
            //foreach (int item in array2)
            //{
            //    Console.Write(item + " ");
            //}


            //3rd
            //int[] sortedArray = { 1, 2, 3, 5, 7, 8, 9 };
            //int target = 5;

            //int index = LinearSearch(sortedArray, target);
            //Console.WriteLine(index);
            //int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16 };
            //int target1 = 10;

            //int result = BinarySearch(numbers, target1);

            //if (result != -1)
            //{
            //    Console.WriteLine("found at index: " + result);
            //}
            //else
            //{
            //    Console.WriteLine(" not found ");
            //}

            //Highest and secondHigest

            //int[] numbers = { 3, 5, 7, 2, 8, 9, 1, 9 };
            //int firstHighest = int.MinValue;
            //int secondHighest = int.MinValue;

            //foreach (int num in numbers)
            //{

            //    if (num > firstHighest)
            //    {
            //        secondHighest = firstHighest;
            //        firstHighest = num;
            //    }
            //    else if (num > secondHighest && num != firstHighest)
            //    {
            //        secondHighest = num;
            //    }
            //}
            //Console.WriteLine("First Highest" + firstHighest);
            //Console.WriteLine("Second Highest" + secondHighest);

            //duplicates in array
            //int[] arr1 = { 1, 2, 3, 4, 2, 5, 3, 6, 7, 8, 1 };
            //Dictionary<int, int> elementCount = new Dictionary<int, int>();
            //foreach (int element in arr1)
            //{

            //    if (elementCount.ContainsKey(element))
            //    {
            //        elementCount[element]++;
            //    }
            //    else
            //    {
            //        elementCount[element] = 1;
            //    }
            //}
            //foreach (var ele in elementCount)
            //{
            //    if (ele.Value > 1)
            //    {
            //        Console.WriteLine(ele.Key + " appears " + ele.Value + " times.");
            //    }
            //}

            //string manipulation

            //assignment 5
            //input - Hello World! This is a simple @we!
            //Console.WriteLine("Enter a string");
            //string str1 = Console.ReadLine().ToLower();


            //int vowels = 0;
            //int consonants = 0;
            //char[] vowArray = { 'a', 'e', 'i', 'o', 'u' };
            //int whiteSpaces = 0;
            //int specialCharacter = 0;
            //foreach (char ele in str1)
            //{
            //    if (vowArray.Contains(ele))
            //    {
            //        vowels++;

            //    }
            //    else if (ele >= 'a' && ele <= 'z')
            //    {
            //        consonants++;
            //    }
            //    else if (char.IsWhiteSpace(ele)) // Check for special characters
            //    {
            //        whiteSpaces++;
            //    }
            //    else
            //    {
            //        specialCharacter++;

            //    }
            //}
            //Console.WriteLine("Vowels: " + vowels);
            //Console.WriteLine("Consonants: " + consonants);
            //Console.WriteLine("White spaces: " + whiteSpaces);
            //Console.WriteLine("Special characters: " + specialCharacter);

            //assignment 6
            //Write a C# program to reverse a string.
            //Console.WriteLine("Enter a string");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Entered string is " + str1);
            //Console.WriteLine("And reversed is ");
            //for (int i = str1.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str1[i]);
            //}
            //Console.WriteLine();

            //assignment 7
            //input->Hello world, world is great.
            //substring world

            //Console.WriteLine("Enter the main string:");
            //string mainString = Console.ReadLine();
            //int count = 0;
            //Console.WriteLine("Enter the substring to search:");
            //string subString = Console.ReadLine();
            //int mainLength = mainString.Length;
            //int subLength = subString.Length;
            //for (int i = 0; i < mainLength - subLength; i++)
            //{
            //    if (mainString.Substring(i, subLength) == subString)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("No of times it occured  " + count);


            //assignment 8;

            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();
            //Console.WriteLine("Uppercase: " + input.ToUpper());
            //Console.WriteLine("Lowercase: " + input.ToLower());

            //string sentence = input.ToLower();
            //string[] words = sentence.Split(' ');

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length > 0)
            //    {

            //        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            //    }
            //}
            //sentence = string.Join(" ", words);
            //Console.WriteLine($"title case {sentence}");

            //assignment-9  removing whitespaces

            //Console.WriteLine("Enter a string:");
            //string input1 = Console.ReadLine();
            //string result = input1.Replace(" ", "");
            //Console.WriteLine("String after removing whitespace: " + result);


            //assignment10
            //input->Hello world, world is great.
            // world
            //Console.WriteLine("Enter the  string:");
            //string mainString = Console.ReadLine();

            //Console.WriteLine("Enter the substring :");
            //string subString = Console.ReadLine();

            //Console.WriteLine("Enter the substring to replace with:");
            //string replaceString = Console.ReadLine();

            //int mainLength = mainString.Length;
            //int subLength = subString.Length;
            //string result = "";

            //for (int i = 0; i < mainLength; i++)
            //{
            //    if (i <= mainLength - subLength && mainString.Substring(i, subLength) == subString)
            //    {

            //        result += replaceString;

            //        i += subLength - 1;
            //    }
            //    else
            //    {
            //        result += mainString[i];
            //    }
            //}
            //Console.WriteLine("Modified string: " + result);

            //assignment 11
            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();
            //string[] arr1 = sentence.Split(' ');
            //string LongestString = "";
            //int maxLength = 0;
            //foreach (string str in arr1)
            //{
            //    if (str.Length > maxLength)
            //    {
            //        maxLength = str.Length;
            //        LongestString = str;
            //    }

            //}
            //Console.WriteLine("Longest word in sentence is  " + LongestString);


            //assignment 12
            //count words in a sentence
            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();
            //string[] arr1 = sentence.Split(' ');

            //int count1 = 0;
            //foreach (string str in arr1)
            //{


            //    count1++;


            //}
            //Console.WriteLine("total words  in senetence is   " + count1);

            //assignment 13
            //program to remove duplicate characters from a string.

            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();
            //Dictionary<char, int> duplicate = new Dictionary<char, int>();
            //foreach (char c in input)
            //{
            //    if (duplicate.ContainsKey(c))
            //    {


            //        duplicate[c]++;
            //    }
            //    else
            //    {
            //        duplicate[c] = 1;

            //    }
            //}
            //foreach (char key in duplicate.Keys)
            //{
            //    if (duplicate[key] >= 1)
            //    {
            //        Console.Write(key);
            //    }
            //}

            //assignment14
            //anagram
            //Console.WriteLine("Enter the first string:");
            //string str1 = Console.ReadLine().Replace(" ", "").ToLower();
            //Console.WriteLine("Enter the second string:");
            //string str2 = Console.ReadLine().Replace(" ", "").ToLower();
            //char[] arr1 = str1.ToCharArray();
            //char[] arr2 = str2.ToCharArray();

            //Array.Sort(arr1);
            //Array.Sort(arr2);
            //bool isEqual = true;
            //if (arr1.Length != arr2.Length)
            //{
            //    Console.WriteLine("length not equal,not anagram");

            //}
            //else
            //{
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        if (arr1[i] != arr2[i])
            //        {
            //            isEqual = false;
            //            break; // Exit loop on first mismatch
            //        }
            //    }
            //    if (isEqual)
            //    {
            //        Console.WriteLine("Anagram");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not anagram");
            //    }
            //}

            //assignment 15

            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();


            //Dictionary<char, int> charFrequency = new Dictionary<char, int>();


            //foreach (char c in input)
            //{

            //    if (charFrequency.ContainsKey(c))
            //    {
            //        charFrequency[c]++;
            //    }
            //    else
            //    {
            //        charFrequency[c] = 1;
            //    }
            //}


            //Console.WriteLine("Character frequencies:");
            //foreach (char key in charFrequency.Keys)
            //{
            //    if (key == ' ')
            //    {
            //        Console.Write($"space:{charFrequency[key]}     ,");

            //    }
            //    else
            //    {
            //        Console.Write($"{key}:{charFrequency[key]}     ,");
            //    }
            //}

            //assignment 16

            //Console.WriteLine("Enter a string:");

            //string input = Console.ReadLine();

            //Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            //foreach (char c in input)
            //{
            //    if (charFrequency.ContainsKey(c))
            //    {
            //        charFrequency[c]++;
            //    }
            //    else
            //    {
            //        charFrequency[c] = 1;
            //    }
            //}
            //foreach (char c in input)
            //{
            //    if (charFrequency[c] == 1)
            //    {
            //        Console.WriteLine($"The first non-repeating character is: '{c}'");
            //        break;
            //    }
            //}

            //assignment 17

            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();


            //string[] words = sentence.Split(' ');


            //for (int i = 0; i < words.Length; i++)
            //{


            //    words[i] = string.Concat(words[i].Reverse());
            //}
            //string reversedSentence = string.Join(" ", words);
            //Console.WriteLine("Reversed sentence:");
            //Console.WriteLine(reversedSentence);


            //assigment  18

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool isDigitsOnly = CheckIfDigitsOnly(input);
            if (isDigitsOnly)
            {
                Console.WriteLine("contains only digits.");
            }
            else
            {
                Console.WriteLine("contains characters other than digits.");
            }

            Console.ReadLine();




        }
    }
}
