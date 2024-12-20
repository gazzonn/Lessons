﻿internal class Program
{
    private static void Main(string[] args)
    {
        byte integer = 255; // Represents an 8-bit unsigned integer from 0 to 255.
        sbyte byt = -128; // Represents an 8-bit signed integer from -128 to 127.
        bool check = false; // Represents a Boolean value, which can be "true" or "false".
        char letter = '\u004B'; // Represents a character as a UTF-16 code unit.
        float value = 1.223445253f; // Represents a floating-point number with a precision of 6-9 digits.
        double variable = 4.255252535235235; // Represents a floating-point number with a precision of 15-17 digits.
        decimal dec = 5.3526215234532412341513452345m; // Represents a floating-point number with a precision of 28-29 digits.
        int number = 43; // Represents a 32-bit signed integer from -2,147,483,648 to 2,147,483,647.
        uint num = 4000000000; // Represents a 32-bit unsigned integer from 0 to 4,294,967,295.
        short shrt = 16242; // Represents an 16-bit signed integer from -32,768 to 32,767.
        ushort ushrt = 65535; // Represents an 16-bit unsigned integer from 0 to 65,535.
        long big = 6000000000000000000; // Represents a 64-bit signed integer from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
        ulong large = 15000000000000000000; // Represents a 64-bit unsigned integer from 0 to 18,446,744,073,709,551,615.
        nint com = -34346; // Represents a signed 32-bit or 64-bit integer, a platform-specific type that is used to represent a pointer or a handle.
        nuint bon = 654446; // Represents a unsigned 32-bit or 64-bit integer, a platform-specific type that is used to represent a pointer or a handle.

        Console.WriteLine("Type some text to be displayed in console.");
        var input = Console.ReadLine();
        Console.WriteLine(input);
    }
}