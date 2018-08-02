using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    private double length;

    public double Length
    {
        get { return length; }
        private set
        {
            FieldValidation("Length", value);
            length = value;
        }
    }


    private double width;

    public double Width
    {
        get { return width; }
        private set
        {
            FieldValidation("Width",value);
            width = value;
        }
    }

    

    private double height;

    public double Height
    {
        get { return height; }
        private set
        {
            FieldValidation("Height", value);
            height = value;
        }
    }


    private void FieldValidation(string fieldName,double fieldValue)
    {
        if (fieldValue <= 0)
        {
            throw new ArgumentException($"{fieldName} cannot be zero or negative.");
        }
    }
}

