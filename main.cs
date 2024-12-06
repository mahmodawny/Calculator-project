using System;

class Program {
  static void Main() {
    double n1,n2;
    char op;
    Console.WriteLine("Enter the first number: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter The operation(+,-,*,/,%)  :");
    op = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    n2 = Convert.ToDouble(Console.ReadLine());
     if (op == '+')
    {
        Console.WriteLine($"n1 + n2 = {n1 + n2}");
    }
    else if(op=='-')
    {
        Console.WriteLine($"n1 - n2 = {n1 - n2}");
    }
    else if(op=='*')
    {
        Console.WriteLine($"n1 * n2 = {n1 * n2}");
    }
      else if(op=='/')
    {
        Console.WriteLine($"n1 / n2 = {n1 / n2}");
    }
    else if(op=='%')
    {
        Console.WriteLine($"n1 % n2 = {n1 % n2}");
    }
  }
}