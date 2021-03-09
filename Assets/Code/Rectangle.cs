using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle
{
    public int numberOfVertex;
    public int numberOfSides;
    public int weight;
    public int hight;

    public Rectangle(int anumberOfVertex, int anumberOfSides, int aweight, int ahight)
    {
        numberOfVertex = anumberOfVertex;
        numberOfSides = anumberOfSides;
        weight = aweight;
        hight = ahight;    
    }
}

