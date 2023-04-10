using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCoding
{
    public class CodingRound
    {
        //Check Palindrome i.e 121
        public bool CheckPalindrome(int i)
        {
            bool IsValid = false;

            int result = 0;
            int temp = i;
            int rem;
            while(i!=0)
            {
                rem = i % 10;
                result = result * 10 + rem;
                i = i / 10;
            }
            i = temp;
            if(i==result)
            {
                IsValid = true;
            }


            return IsValid;
        }
        //Check Even Or Odd
        public bool CheckEvenOdd(int i)
        {
            bool IsValid = false;

            if (i % 2 == 0)
            {
                IsValid = true;
            }

            return IsValid;
        }

        //Fibonacciseries 0 1 1 2 3 5 8 ..
        public void FibonacciSeries(int n)
        {
            int firstNo = 0;
            int secondNo = 1;
            int thirdNo;
            Console.WriteLine(firstNo);
            Console.WriteLine(secondNo);
            for (int i=2;i<n;i++)
            {
                thirdNo = firstNo + secondNo;
                Console.WriteLine(thirdNo + " ");
                firstNo = secondNo;
                secondNo = thirdNo;
            }
        }

        public void Add(int i,int j)
        {
            int sum = i + j;
            Console.WriteLine("Sum is : " + sum);
        }

        public void Add(int i,out int j)
        {
            j = 1;
            int sum = i + j;
            Console.WriteLine("Sum is : " + sum);
        }

        public void Print(int i)
        {
            if (i==1)
            {
                Console.WriteLine("Name Only");
            }
            else if(i==2)
            {
                Console.WriteLine("SurName");
            }
            else
            {
                Console.WriteLine("FullName");
            }
            return;
        }
        //Pyramid Pattern Print
        public void PrintPyramid()
        {

            for(int i=1;i<=5;i++)
            {
                for(int j=i;j<=4;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                for(int m=2;m<=i;m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Amstrong 153
        public void AmstrongNumber(int j)
        {
            int rem = 0;
            int result = 0;
            int cube;
            while(j!=0)
            {
                rem = j % 10;
                cube = rem * rem * rem;
                result = result + cube;
                j = j / 10;
            }
            Console.WriteLine("Amstrong Number is : " + result);
        }

        //Reverse Number 1234 4321
        public void ReverseNumber(int num)
        {
            int result = 0;
            int rem = 0;
            int temp=num;
            ArrayList arr = new ArrayList();
            while(num!=0)
            {
                rem= num % 10;
                result =  rem;
                
                arr.Add(result);
                num = num / 10;
            }
            Console.WriteLine("Original Number : "+temp);
            Console.Write("Reverse Number : ");
            foreach (var i in arr)
            {
                Console.Write(i);
            }
            
        }
        //public int i = 0;
        public  int GetRecursive(int num)
        {
            
            if((num==0))
            {
                
                return 0;
                
            }else if(num==1 || num==2)
            {
                return 1;
            }
            
            else 
            {
                return (GetRecursive(num - 1) + GetRecursive(num - 2));
            }
        }

        //Occurence of digit 7 in series
        public void FindNoOfOccurencesOfDigitSevenInSeries(int digit,int number)
           {
           
            int counter = 0;

            for(int i = digit; i < number; i++) 
            { 
            int x = i;
                while(x>0)
                {
                    int rem = x % 10;
                    x = x / 10;
                    if(rem==digit)
                    {
                        counter++;
                    }
                }

            }



            Console.WriteLine("Count of digit "+ digit +" upto Nth number "+ number +" have count " + counter);
        }

        //Print the Largest Number and Second Largest Number from an Series
        public void PrintLargestNumbers(int[] arr)
        {
            int count = arr.Length;
            int temp;
            for(int i=0;i<count;i++)
            {
                for(int j=i+1;j<count;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Largest number is : " + arr[count-1]);
            Console.WriteLine("Second Largest number is : " + arr[count-2]);



        }
        //Bubble Sort 

        public void BubbleSort(int[] unsortedlist)
        {

            for(int i=0;i<unsortedlist.Length-1;i++)
            {

                for(int j=0;j<unsortedlist.Length-(1+i);j++)
                {

                    if (unsortedlist[j] > unsortedlist[j+1])
                    {
                        int temp = unsortedlist[j];
                        unsortedlist[j] = unsortedlist[j + 1];
                        unsortedlist[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted List is : ");
            for(int i=0;i<unsortedlist.Length;i++)
            {
                Console.Write(unsortedlist[i] +", ");
            }
        }

        //Check Prime Number

        public void CheckPrimeNumber(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            if(count==2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }

    }
    
}
