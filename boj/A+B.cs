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


저장방법
1. git add . // 저장하기
2. git commit -m "feat: A-B" // 저장할 메세지 입력하기
3. git push origin main // 원격 저장소로 보내기
*/