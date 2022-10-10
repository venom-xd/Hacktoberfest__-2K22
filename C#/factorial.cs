using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
public class csharpExercise
{
    static void Main(string[] args)
    {        
        int num,i;
        long fact=1;
 
        // Reading number
        Console.Write("Enter any number to calculate factorial:  ");
        num = Convert.ToInt32(Console.ReadLine());
        fact = 1;
        i = 1;
 
        //Run loop from 1 to number entered by user
        while(i <= num)
        {
            fact = fact * i;
            i++;
        }            
 
        Console.Write("Factorial of : "+ num +" is " + fact);
 
        Console.ReadLine();
    }
}
