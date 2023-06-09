using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Sample data
        List<int> numbers = new List<int> { 1, 5, 2, 4, 3, 6 };

        // 1. Basic LINQ: Query syntax
        var querySyntax = from num in numbers
                          where num % 2 == 0
                          orderby num descending
                          select num;

        Console.WriteLine("Query Syntax:");
        foreach (var num in querySyntax)
        {
            Console.WriteLine(num);
        }

        // 2. General query form: Method syntax
        var methodSyntax = numbers
            .Where(num => num % 2 == 0)
            .OrderByDescending(num => num);

        Console.WriteLine("\nMethod Syntax:");
        foreach (var num in methodSyntax)
        {
            Console.WriteLine(num);
        }

        // 3. Where, orderby, select, from, group operators
        var queryOperators = from num in numbers
                             where num > 2
                             orderby num ascending
                             select num * 2;

        Console.WriteLine("\nQuery Operators:");
        foreach (var num in queryOperators)
        {
            Console.WriteLine(num);
        }

        // 4. Operators let, join
        var queryJoin = from num1 in numbers
                        join num2 in queryOperators on num1 equals num2
                        select new { Num1 = num1, Num2 = num2 };

        Console.WriteLine("\nJoin Example:");
        foreach (var pair in queryJoin)
        {
            Console.WriteLine($"{pair.Num1} - {pair.Num2}");
        }

        // 5. Query methods
        var queryMethods = numbers
            .Where(num => num % 2 != 0)
            .OrderBy(num => num)
            .Select(num => num.ToString());

        Console.WriteLine("\nQuery Methods:");
        foreach (var num in queryMethods)
        {
            Console.WriteLine(num);
        }

        // 6. Exceptions and exception handling
        try
        {
            var queryException = from num in numbers
                                 where num > 10
                                 select num;

            Console.WriteLine("\nQuery with Exception:");
            foreach (var num in queryException)
            {
                Console.WriteLine(num);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
