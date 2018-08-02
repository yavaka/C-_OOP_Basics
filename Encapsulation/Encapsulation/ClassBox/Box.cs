using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    public Box(double lenght, double width, double height)
    {
        this.lenght = lenght;
        this.width = width;
        this.height = height;
    }

    private double lenght;

    public double Lenght
    {
        get { return lenght; }
        set { lenght = value; }
    }


    private double width;

    public double Width
    {
        get { return width; }
        set { width = value; }
    }


    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

}

