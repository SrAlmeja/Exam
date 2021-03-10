using UnityEngine;

public class Enemigo : Circle1
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
            if (value == 25)
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
            if (value == "Wajajaja te woi a matar")
            {
                presentation = value;
            }
            else
            {
                presentation = "...";
            }
        }
    }
    public Enemigo(int adamage, int aspeed, string apresentation)
    {
        damage = adamage;
        speed = aspeed;
        presentation = apresentation;
    }

}