using System;

public class Example
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        Console.WriteLine($"{A + B}");



    }
}


/*
실행방법

1. dotnet new console -n test
2. cd test
3. dotnet run
4. 입력값 입력

*/