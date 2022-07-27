using System;

/*
public class MyClass
{
    public static void MyMethod()
    {
        Console.WriteLine("클래스");
    }
}

class ClassDescription
{
    static void Main()
    {
        MyClass.MyMethod();
    }
}
*/

/*
public class ClassName
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");

    }
}

public class ClassAndMember
{
    public static void Main()
    {
        ClassName.MemberName();
    }
}
*/

/*
using System.Diagnostics;

namespace DotNet
{
    class ProcessStartDemo
    {
        static void Main()
        {
            Process.Start("Notepad.exe");
            Process.Start("Explorer.exe", "https://dotnetkorea.com");
        }
    }
}
*/

/*

class RandomDemo
{
    static void Main()
    {
        Random random = new Random();
        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next(5));
        Console.WriteLine(random.Next(1,10));
    }
}
*/

/*
class RandomClassDemo
{
    static void Main()
    {
        Console.Write("이번 주의 로또 : ");
        Random ran = new Random();
        int[] arr = new int[6];
        int temp = 0;

        for(int i = 0; i < 6; i++)
        {
            temp = ran.Next(45)+ 1;
            bool flag = false;
            if (i > 0 && i < 6)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (arr[j] == temp)
                        flag = true;
                }
            }

            if (flag)
            {
                --i;
            }
            else
            {
                arr[i] = temp;
            }
        }
        for(int i = 0; i < 6; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
    }
}
*/

/*
using System;
using System.Text.RegularExpressions;

class RegexReplace
{
    static void Main()
    {
        string s = "안녕하세요.      반갑습니다.    또 만나요.";
        var regex = new Regex("\\s+");
        string r = regex.Replace(s, " ");
        Console.WriteLine(s);
        Console.WriteLine(r);

    }
}
*/

/*
using System;
using System.Text.RegularExpressions;

class RegexDemo
{
    static void Main()
    {
        string email = "abcd@aaa.com";
        Console.WriteLine(IsEmail(email));
    }

    static bool IsEmail(string email)
    {
        try
        {
            bool result = false;

            Regex regex = new Regex(@"^[A-Za-Z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)" + @"(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-Z]{2,})$");

            result = regex.IsMatch(email);

            return result;
        }
        catch
        {
            return true;
        }
    }
}
*/

/*
using System;
class TryFinallyDemo
{
    static void Main()
    {
        Console.WriteLine("[1] 시작");

        try
        {
            Console.WriteLine("[2] 실행");
            throw new Exception();
        }
        catch
        {
            Console.WriteLine("예외 발생");
        }
        finally
        {
            Console.WriteLine("[3] 종료");
        }
    }
}


*/

using System;

class ExceptionHandling
{
    static void Main()
    {
        int a = 3;
        int b = 0;

        try
        {
            a = a / b;
        }

        catch(Exception ex)
        {
            Console.WriteLine($"예외(에러)가 발생된 : {ex.Message}");

        }

        finally
        {
            Console.WriteLine("try 구문을 정상 종료.");
        }

        try
        {
            throw new Exception("내가 만든 에러");
        }
        catch(Exception e)
        {
            Console.WriteLine($"에러 발생 {e.Message}");

        }
        finally
        {
            Console.WriteLine("try 구문 정상 종료.");
        }
    }
}