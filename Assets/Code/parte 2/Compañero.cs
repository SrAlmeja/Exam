using UnityEngine;

public class Compañero : Circle1
{
    //Atributes
    private int speed, damage;
    private string presentation;

    public int Speed
    {
        get { return speed; }
        set
        {
            if (value == 20)
            {
                speed = value;
            }
            else
            {
                speed = 0;
            }
        }
    }

    public int Damage
    {
        get { return damage; }
        set
        {
            if (value == 5)
            {
                damage = value;
            }
            else
            {
                damage = 0;
            }
        }
    }

    public string Presentation
    {
        get { return presentation; }
        set
        {
            if (value == "¡Él es mi NAKAMAAA!")
            {
                presentation = value;
            }
            else
            {
                presentation = "...";
            }
        }
    }
    public Compañero(int adamage, int aspeed, string apresentation)
    {
        damage = adamage;
        speed = aspeed;
        presentation = apresentation;
    }

}
