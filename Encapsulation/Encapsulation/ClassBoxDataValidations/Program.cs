using System;


class Program
{
    static void Main(string[] args)
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        try
        {
            var box = new Box(length, width, height);
            SurfaceArea(box);
            LateralSurfaceArea(box);
            Volume(box);
        }
        catch (ArgumentException argExc)
        {
            Console.WriteLine(argExc.Message);
        }
    }

    private static void Volume(Box box)
    {
        var volume = box.Length * box.Width * box.Height;
        Console.WriteLine($"Volume - {volume:F2}");
    }

    private static void LateralSurfaceArea(Box box)
    {
        var lateralSurfaceArea = (2 * box.Length * box.Height) + (2 * box.Width * box.Height);
        Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");
    }

    private static void SurfaceArea(Box box)
    {
        var surfaceArea = (2 * box.Length * box.Width) + (2 * box.Length * box.Height) + (2 * box.Width * box.Height);
        Console.WriteLine($"Surface Area - {surfaceArea:F2}");
    }
}

