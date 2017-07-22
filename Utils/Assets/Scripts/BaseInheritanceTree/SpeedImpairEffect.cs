using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedImpairEffect
{
    float value = 0.0f;
    const float MAX_MODIFIER = 2.0f;
    const float MIN_MODIFIER = 0.0f;

    public void setValue(float val)
    {
        if (val <= MIN_MODIFIER) value = MIN_MODIFIER;
        else if (val >= MAX_MODIFIER) value = MAX_MODIFIER;
        else
            value = val;
    }

    public float getValue()
    {
        return value;
    }
}