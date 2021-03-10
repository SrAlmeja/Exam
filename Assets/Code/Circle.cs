using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle
{
    //Atributos
    public int numberOfVertex;
    public int radious;
    public string speed;
    public string color;
    public int damage;
    public int points;
    public string Presentation;

    Bala thebullet = new Bala(200, 0);
    Moneda theCoin = new Moneda("yellow", 20);
    Enemigo theNemesis = new Enemigo(20, 25, "Wajajaja te woi a matar");
    Compañero theFriend = new Compañero(20, 5, "¡Él Es mi NAKAMAAA!");

    public void Start()
    {
        ObjectCircle();
    }

    public Circle(int anumberOfVertex, int aradious)
    {
        numberOfVertex = anumberOfVertex;
        radious = aradious;
    }

    public Circle()
    {

    }

    public void ObjectCircle()
    {

    }

}
