public class Challenge_one
{
    public void PrintNumbers()
    {
        for (int = 1; i <=10; ++i);
    }

    public void PrintStrings(string[] arr)
    {
         int array[] = {1, 2, 3, 3, 4, 5, 6, 7 ,8 ,9 ,10 ,0};
         arraySize(array, sizeof(array)/sizeof(array[0]));  
         
         //adding size of array as new argument

    return 0;
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        /*
        Todo: Check if a number is positive, negative or zero.
        */
         Console.WriteLine("Enter First Nuumber: ");
        string firstAsString = Console.ReadLine();
        int first = Convert.ToInt32(firstAsString);


        Console.WriteLine("Enter Second Nuumber: ");
        string secondAsString = Console.ReadLine();
        int second = Convert.ToInt32(secondAsString);


        bool firsNumberPositive;
        bool secondNumberPositive;


        if (first > 0) {
            firsNumberPositive = true;
        }
        else
        {
            firsNumberPositive = false;
        }

        if (second > 0)
        {
            secondNumberPositive = true;
        }
        else
        {
            secondNumberPositive = false;
        }

        if (firsNumberPositive && secondNumberPositive || !firsNumberPositive && !secondNumberPositive)
            Console.WriteLine("Answer Is Positive");
        else
            if (!firsNumberPositive && secondNumberPositive || firsNumberPositive && !secondNumberPositive) 
        Console.WriteLine("Answer Is Negative");

        Console.ReadLine(); 
    }


}