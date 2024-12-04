using System;


namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            int[] array1 = new int[5];

            int[] array2 = new int[] { 10, 20, 30, 40, 50 };

            int[] array3 = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 1;
            }

            Console.WriteLine("Array1:");
            foreach (int value in array1)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Array2:");
            foreach (int value in array2)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Array3:");
            foreach (int value in array3)
            {
                Console.WriteLine(value);
            }

            try
            {
                Console.WriteLine(array1[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOut Of RangeException caught: " + ex.Message);


                /*What is the default value assigned to array elements in C#? 
                the default In C# value assigned to array elements of type int is 0.
               if you create an array of integers
              and do not explicitly assign values to its elements,
                 they will all be initialized to 0.
 */
                #endregion

                #region problem 2

                int[] arr1 = { 1, 2, 3, 4, 5 };
                int[] arr2 = new int[arr1.Length];

                arr1.CopyTo(arr2, 0);

                arr1[0] = 90;
                Console.WriteLine("After modifying arr1:");
                Console.WriteLine("arr1: " + string.Join(", ", arr1));
                Console.WriteLine("arr2: " + string.Join(", ", arr2));

                int[] arr3 = (int[])arr1.Clone();

                arr1[1] = 80;
                Console.WriteLine("After modifying arr1 again:");
                Console.WriteLine("arr1: " + string.Join(", ", arr1));
                Console.WriteLine("arr3: " + string.Join(", ", arr3));

                /*   Array.Clone():
                       Creates a shallow copy of the array Returns a new array of the same type
                    Elements are copied by value for value types by reference for reference types.
                 Array.Copy():
                  Copies elements from the source array to the destination array.
                  Can copy to an existing array and allows specifying the starting index.
                  Suitable for copying part of an array or to a different - sized array*/

                #endregion

                #region prolem 3

                int[,] grades = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter grades for student {i + 1}:");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Subject {j + 1}: ");
                        grades[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nGrades for each student:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Student {i + 1}:");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Subject {j + 1}: {grades[i, j]}");

                        /*Difference Between GetLength() and Length for Multi-Dimensional Arrays
                                  in the specified dimension of the array.
                         For example:
                          grades.GetLength(0) returns the number of rows (students),
                          grades.GetLength(1) returns the number of columns (subjects).

                         Length: This property returns the total number of elements in the array.
                           For a 3x3 array, grades.Length would return 9, as there are 9 elements in total
*/

                    }
                }
            }
            #endregion

            #region problem 4
            int[] array = { 50, 20, 30, 10, 40 };

            Array.Sort(array);
            Console.WriteLine("After Sort: " + string.Join(", ", array));
            Array.Reverse(array);
            Console.WriteLine("After Reverse: " + string.Join(", ", array));

            int index = Array.IndexOf(array, 40);
            Console.WriteLine("Index of 40: " + index);

            int[] arrayCopy = new int[array.Length];
            Array.Copy(array, arrayCopy, array.Length);
            Console.WriteLine("After Copy: " + string.Join(", ", arrayCopy));

            Array.Clear(array, 0, array.Length);
            Console.WriteLine("After Clear: " + string.Join(", ", array));

            /*
             Array.Copy():
               Copies elements from one array to another.
                If an error occurs the target array might end up in an incomplete or partial state.

             Array.ConstrainedCopy():
                 is similar to Array.Copy():
                 Ensures that if an error occurs during the copy operation the target array remains unchanged.
             */

            #endregion

            #region problem 5
            int[] num = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Using for loop:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("Using foreach loop:");
            foreach (int element in num)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Using while loop (reverse order):");
            int Index = num.Length - 1;
            while (Index >= 0)
            {
                Console.WriteLine(num[Index]);
                Index--;
            }

            /*because:

                  Simplicity It provides a simpler and more readable syntax for iterating
                  through all elements of an array
                 Safety
                The foreach loop does not allow changing the elements of the array
               making it ideal for read-only operations

               Less Error-Prone: It eliminates the need for managing loop counters
              and boundary conditions, which can be a source of errors in for and while loops.
              */


            #endregion


            #region problem6
            int number;
            bool isValid;

            do
            {
                Console.WriteLine("Please enter a positive odd number:");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out number) && number > 0 && number % 2 != 0;

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Make sure it's a positive odd number.");
                }
            } while (!isValid);

            Console.WriteLine($"You entered a valid positive odd number: {number}");

            /*Data Integrity is ensures that the data processed by the program is accurate and consistent,
                          
               Reliability is ensures that the program operates correctly
               by handling unexpected
            or incorrect inputs gracefully.
                  */


            #endregion

            #region problem7
            int[,] matrix =
        {
            { 10, 15, 20 },
            { 25, 30, 35 },
            { 40, 45, 50 }
        };

            Console.WriteLine("Matrix Format:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadRight(4));
                }
                Console.WriteLine();
            }

            /*
             Using String Interpolation ($"{value}"):
               String interpolation allows you to control the format of each element 
             Adding Separators (like |) Between Columns
             */
            #endregion

            #region problem10
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sumFor = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumFor += numbers[i];
            }
            Console.WriteLine("Sum using for loop: " + sumFor);

            int sumForeach = 0;
            foreach (int element in numbers)
            {
                sumForeach += element;
            }
            Console.WriteLine("Sum using foreach loop: " + sumForeach);

            /*
                while both loops are efficient for calculating the sum of an array
                 the foreach loop is often preferred for its simplicity and readability
                   in read-only operations.
            for loop can be more flexible when you need to work with indices or modify the array elements
            
             */

            #endregion
        }

    }
}
