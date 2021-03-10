using UnityEngine;

public class Moneda : Circle1
{
    //Atributes
    private string color;
    private int points;

    public string Color
    {
        get { return color; }
        set
        {
            if (value == "Yellow")
            {
                color = value;
            }
            else
            {
                Color = "yo no soy una moneda";
            }
        }
    }

    public int Points
    {
        get { return points; }
        set
        {
            if (value == 20)
            {
                points = value;
            }
            else
            {
                points = 0;
            }
        }
    }

    public Moneda(string acolor, int apoints)
    {
        color = acolor;
        points = apoints;
    }
}

