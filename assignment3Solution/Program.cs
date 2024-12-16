using System;

namespace assignment3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter a number :");
            //int number = int.Parse(Console.ReadLine());
            //if(number >= 0)
            //{
            //    Console.WriteLine("Postitive");
            //}
            //else
            //{
            //    Console.WriteLine("Negative");
            //}
            #endregion

            #region Q3
            //Console.WriteLine("Enter three integers separated by space :");
            //string[] input = Console.ReadLine().Split(' ');

            //int num1 = int.Parse(input[0]);
            //int num2 = int.Parse(input[1]);
            //int num3 = int.Parse(input[2]);

            //int Max = Math.Max(Math.Max(num1, num2), num3);
            //int Min = Math.Min(Math.Min(num1, num2), num3);

            //Console.WriteLine($"MAX  = {Max}");
            //Console.WriteLine($"MIN  = {Min}");




            #endregion

            #region Q4
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion

            #region Q5
            //Console.WriteLine("Enter a Character :");
            //char ch = char.Parse(Console.ReadLine());

            //ch = Char.ToLower(ch);
            //string vowels = "aeiou";

            //if (vowels.Contains(ch))
            //{
            //    Console.WriteLine("Vowels");
            //}
            //else
            //{
            //    Console.WriteLine("Constant");
            //}
            #endregion

            #region Q6
            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());
            //for ( int i = 1; i <= number; i++)
            //{
            //    Console.Write(i + " ");

            //}
            #endregion

            #region Q7
            //Console.WriteLine("Enter a number :");
            //int number = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= 12; i++)
            //{
            //    Console.Write(i * number + " ");
            //}


            #endregion

            #region Q8


            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion


            #region Q9
            //Console.WriteLine("Enter base number :");

            //int baseNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter exponent  :");

            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= baseNumber;
            //}
            //Console.WriteLine(result);



            #endregion

            #region Q10
            //Console.WriteLine("Enter marks of five subjects:");
            //int total = 0;

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Subject {i}: ");
            //    int marks = int.Parse(Console.ReadLine());
            //    total += marks;
            //}

            //double average = total / 5.0;
            //double percentage = average;

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");
            #endregion

            #region Q11
            //Console.Write("Enter month number: ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28 or 29");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //}
            #endregion

            #region Q12

            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char operation = char.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //double result = 0;

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //            result = num1 / num2;
            //        else
            //            Console.WriteLine("Error: Division by zero");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        return;
            //}

            //Console.WriteLine($"Result: {result}");



            #endregion

            #region Q13
            /*       Console.WriteLine("Enter a string :");
                   string input = Console.ReadLine();
                   char[] charArr = input.ToCharArray();
                   Array.Reverse(charArr);
                   string Reversed = new string(charArr);

                   Console.WriteLine($"THE REVERSED STRING {Reversed}");*/
            #endregion

            #region Q14
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while(number != 0)
            //{
            //    int remainder = number % 10;
            //    reversed = reversed * 10 + remainder;
            //    number /= 10;
            //}
            //Console.WriteLine($"Reversed number : {reversed}");


            #endregion


            #region Q15

            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("The prime numbers between " + start + " and " + end + " are:");

            //for (int number = start; number <= end; number++)
            //{
            //    if (IsPrime(number))
            //    {
            //        Console.Write(number + " ");
            //    }
            //}

            //static bool IsPrime(int number)
            //{
            //    if (number <= 1) return false;

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0) return false;
            //    }

            //    return true;
            //
            //}
            #endregion

            #region Q16
            //Console.Write("Enter a number to convert: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //string binary = ConvertToBinary(decimalNumber);

            //Console.WriteLine($"The Binary of {decimalNumber} is {binary}");


            //static string ConvertToBinary(int number)
            //{
            //    if (number == 0) 
            //        return "0";

            //    string binary = "";

            //    while (number > 0)
            //    {
            //        binary = (number % 2) + binary;
            //        number /= 2;
            //    }

            //    return binary;
            //}
            #endregion

            #region Q17
            //    Console.WriteLine("Enter coordinates of three points:");

            //    Console.Write("x1: ");
            //    double x1 = double.Parse(Console.ReadLine());
            //    Console.Write("y1: ");
            //    double y1 = double.Parse(Console.ReadLine());

            //    Console.Write("x2: ");
            //    double x2 = double.Parse(Console.ReadLine());
            //    Console.Write("y2: ");
            //    double y2 = double.Parse(Console.ReadLine());

            //    Console.Write("x3: ");
            //    double x3 = double.Parse(Console.ReadLine());
            //    Console.Write("y3: ");
            //    double y3 = double.Parse(Console.ReadLine());

            //    bool onLine = IsPointsOnLine(x1, y1, x2, y2, x3, y3);

            //    if (onLine)
            //    {
            //        Console.WriteLine("The points lie on a single straight line.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The points do not lie on a single straight line.");
            //    }


            //static bool IsPointsOnLine(double x1, double y1, double x2, double y2, double x3, double y3)
            //    { 
            //    double area = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;

            //    return area == 0;
            //}



            #endregion


            #region Q18
            //Console.Write("Enter time taken to complete the task (in hours): ");
            //double time = double.Parse(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //{
            //    Console.WriteLine("Highly efficient");
            //}
            //else if (time > 3 && time <= 4)
            //{
            //    Console.WriteLine("Increase speed");
            //}
            //else if (time > 4 && time <= 5)
            //{
            //    Console.WriteLine("Provide training to enhance speed");
            //}
            //else if (time > 5)
            //{
            //    Console.WriteLine("Leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid time input");
            //}
        

        #endregion

    }
}
}