using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats
{
    float health;
    float armour;
    float speed;
    bool immune = false;

    List<SpeedImpairEffect> speedModifiers;

    public bool isImmune()
    {
        return immune;
    }

    public void setImmune(bool immune)
    {
        this.immune = immune;
    }
   
    public bool isDead()
    {
        return health <= 0.0f;
    }

    public bool hasArmour()
    {
        return armour <= 0.0f;
    }

    public float SpeedWithModifiers()
    {
        float speedWithModifiers = 1.0f;

        foreach (SpeedImpairEffect speedImpairEffect in speedModifiers)
        {
            speedWithModifiers *= speedImpairEffect.getValue();
        }

        return speedWithModifiers;
    }

}