// See https://aka.ms/new-console-template for more information
using InterviewCoding;
CodingRound code = new CodingRound();

Console.WriteLine("Enter Your Number To Check Palindrome : ");
int i = Convert.ToInt32(Console.ReadLine());



bool Valid = code.CheckPalindrome(i);

if(Valid==true)
{
    Console.WriteLine("Is Palindrome");
}
else
{
    Console.WriteLine("Is Not Palindrome");
}

Console.WriteLine("Enter Your Number To Check Even or Odd : ");
int j = Convert.ToInt32(Console.ReadLine());
Valid = code.CheckEvenOdd(j);
if (Valid == true)
{
    Console.WriteLine("Even Number");
}
else
{
    Console.WriteLine("Odd Number");
}

Console.WriteLine("Enter Your Series : ");
int k = Convert.ToInt32(Console.ReadLine());
code.FibonacciSeries(k);
int p;
Console.WriteLine("Enter your number");
p = int.Parse(Console.ReadLine());
int q = 1;
for (int l = 0;  l<p; l++) { 
    Console.WriteLine(q+" Index "+code.GetRecursive(l));
    q++;
}

Console.WriteLine("Enter Your First Number : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Second Number : ");
int y = Convert.ToInt32(Console.ReadLine());
code.Add(x, y);
code.Add(x, out y);

Console.WriteLine("1 . Name Only");
Console.WriteLine("2 . SurName");
Console.WriteLine("3 . FullName ");
Console.WriteLine("Enter Your Option : ");
int z = Convert.ToInt32(Console.ReadLine());

code.Print(z);
code.PrintPyramid();
code.AmstrongNumber(153);
Console.WriteLine("Enter the Number you want to reverse : ");
int m = Convert.ToInt32(Console.ReadLine());
code.ReverseNumber(m);

Console.WriteLine();


Console.WriteLine("Enter the Number of elements you want to enter :");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[n];
int s;
for (int r = 0; r < n; r++)
{
    Console.WriteLine("Enter the elements :");
    s = Convert.ToInt32(Console.ReadLine());
    arr1[r] = s;
}
code.PrintLargestNumbers(arr1);
Console.WriteLine("Find Occurences of a digit in series");
Console.WriteLine("Enter the digit and the Nth number :");
int digit = Convert.ToInt32(Console.ReadLine());
int Nth = Convert.ToInt32(Console.ReadLine());



code.FindNoOfOccurencesOfDigitSevenInSeries(digit, Nth);

Console.WriteLine("Enter the Number of elements you want to enter :");
int w = Convert.ToInt32(Console.ReadLine());
int[] unsortedlist = new int[w];
int v;
for (int r = 0; r < w; r++)
{
    Console.WriteLine("Enter the elements :");
    v = Convert.ToInt32(Console.ReadLine());
    unsortedlist[r] = v;
}
code.BubbleSort(unsortedlist);

Console.WriteLine("Enter the Number to check whether it is prime or not :");
int o = Convert.ToInt32(Console.ReadLine());
code.CheckPrimeNumber(o);

  
Test test = new Test();
test.TestVal();
test.Display();
Console.ReadLine();
