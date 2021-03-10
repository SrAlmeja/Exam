using UnityEngine;

public class Bala : Circle1
{
    //Atributes
    private int speed, damage;

    public int Speed
    {
        get { return speed; }
        set
        {
            if (value == 200)
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
            if (value == 999)
            {
                damage = value;
            }
            else
            {
                damage = 0;
            }
        }
    }
    public Bala(int adamage, int aspeed)
    {
        damage = adamage;
        speed = aspeed;
    }

}

