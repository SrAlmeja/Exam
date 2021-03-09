using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureGenerator : MonoBehaviour
{
    public int createFigure;
    Circle theCircle = new Circle(0, 10);
    Square theSquare = new Square(4, 4, 10);
    Triangle theTriangle = new Triangle(3, 3, 10);
    Rectangle theRectangle = new Rectangle(4, 4, 10, 15);


    public void Start()
    {
        FigureCreator();
    }
    public void FigureCreator()
    {
        createFigure = Random.Range(1, 5);

        switch (createFigure)
        {
            case 1:
            Debug.Log("Felicidades has construido un circulo de:" + theCircle.numberOfVertex + theCircle.radious);
                break;
            case 2:
            Debug.Log("Felicidades has construido un cuadrado de:" + theSquare.numberOfVertex + theSquare.numberOfSides + theSquare.leinghtOfSides);
                break;
            case 3:
            Debug.Log("Felicidades has construido un triangulo de:" + theTriangle.numberOfVertex + theTriangle.numberOfSides + theTriangle.lengthOfSides);
                break;
            case 4:
            Debug.Log("Felicidades has construido un rectangulo de:" + theRectangle.numberOfVertex + theRectangle.numberOfSides + theRectangle.hight + theRectangle.weight);
                break;
        }
    }
}
