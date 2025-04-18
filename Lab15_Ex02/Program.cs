﻿using static System.Console;

WriteLine(Calculator.AddValues(2, 3));
WriteLine(Calculator.AddValues(2.0f, 3.0f));
WriteLine(Calculator.AddValues(2L, 3L));

public static class Calculator
{
    public static int AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }

    // เปลี่ยนประเภทพารามิเตอร์เป็น float
    public static float AddValues(float c, float d)
    {
        WriteLine("Calculated by method: public static float AddValues(float c, float d)");
        return c + d;
    }

    public static long AddValues(long h, long i)
    {
        WriteLine("Calculated by method: public static long AddValues(long h, long i)");
        return h + i;
    }
}