using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerStat : Stat
{

    public override void chooseBonusOrMalus(Collision2D collision)
    {
        collision.gameObject.GetComponent<Warrior>().defensePoints += 2;
        Debug.Log(collision.gameObject.GetComponent<Warrior>().defensePoints);
    }
}