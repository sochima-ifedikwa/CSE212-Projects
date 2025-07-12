using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
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

        //Step 1: Define the array that will hold the multiples of the number
        double [] multiples = new double [length];

        //Step 2: Loop through the array and fill it with the multiples of the number
        for (int i = 0; i < length; i++)
        {
            //Step 3: Calculate the multiple of the number for the current index
            double multiple = number * (i + 1);
            //Step 4: Store the multiple in the array
            multiples[i] = multiple;
        }
        //Step 5: Return the array of multiples
        return multiples; // replace this return statement with your own
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step 1: Check to make sure that the list is not empty or out of range
        if (data == null || data.Count == 0)
        {
            throw new ArgumentException("The list is empty");
        }
        //Step 2: Check to make sure that the amount is within the valid range
        if (amount < 1 || amount > data.Count)
        {
            throw new ArgumentException("The amount is out of range");
        }

        //Step 3: Calculate the actual amount of rotation needed
        int actualAmount = amount % data.Count;

        //Step 4: Split the list into two parts at the actual amount of rotation
        // first part of the list will be the last 'actualAmount' elements of the list
        List<int> firstPart = data.GetRange(data.Count - actualAmount, actualAmount);
        // second part of the list will be the rest of the list
        List<int> secondPart = data.GetRange(0, data.Count - actualAmount);

        //Step 5 :Combine the 2 parts fo the lists
        data.Clear();
        data.AddRange(firstPart);
        data.AddRange(secondPart);

          

    }
}
