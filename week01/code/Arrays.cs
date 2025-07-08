public static class Arrays
{
    /// <summary> \]
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// ];≤≤
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //****PLAN*****

        //Step 1: Create a new array that can hold each multiple number
        //Multiplesof(6,5) should give us {6, 12, 18,24,30}. 
        //So we need an array of size 5 to hold the result.
        double[] result = new double[length];


        //Step 2: Use a loop to go from 0 to length -1
        // In each loop step, calculate the multiple : number *(i+i)
        //Then store the result into the array at index i.
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        //Step 3: After the loop, return the array with all the multiples in it

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    
    public static void RotateListRight(List<int> data, int amount)
{
    // TODO Problem 2 Start
    // Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.

    // **** PLAN ****

    // Step 1: Make sure the list isn't empty or null.
    if (data == null || data.Count == 0 || amount % data.Count == 0)
    {
        return;
    }

    // Step 2: Normalize the amount using modulo in case it's bigger than the list size.
    amount = amount % data.Count;

    // Step 3: Use GetRange to create two slices:
    // - Slice from the end (the part to rotate to the front)
    // - Slice from the beginning to the cut point
    List<int> endSlice = data.GetRange(data.Count - amount, amount);
    List<int> startSlice = data.GetRange(0, data.Count - amount);

    // Step 4: Clear the original list
    data.Clear();

    // Step 5: Add both slices back in rotated order
    data.AddRange(endSlice);
    data.AddRange(startSlice);
}

     
    }

