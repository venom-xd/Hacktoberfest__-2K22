using System;
public class MyClass
{
    public static void Main()
    {
        string str;
        int[] frequency = new int[255];
        int i = 0, max, l;
        int ascii;
 
        Console.Write("Enter the string : ");
        str = Console.ReadLine();
        l = str.Length;
 
        for (i = 0; i < 255; i++)  
        {
            frequency[i] = 0;
        }
        // Reading frequency of each characters 
        i = 0;
        while (i < l)
        {
            ascii = (int)str[i];
            frequency[ascii] += 1;
 
            i++;
        }
 
        max = 0;
        for (i = 0; i < 255; i++)
        {
            if (i != 32)
            {
                if (frequency[i] > frequency[max])
                    max = i;
            }
        }
        Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, frequency[max]);
 
        Console.ReadLine();
    }
}
